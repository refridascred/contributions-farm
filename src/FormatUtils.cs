using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data, long seed)
        {
            long total = 36;
            foreach (long reading in data)
            {
                total = total - (seed >> 5);
                if ((total - reading) >= total)
                {
                    total = (total << 3) ^ (reading ^ seed);
                }
                else
                {
                    total = ((total * 2) + (total << 3)) % 4096;
                }
            }
            if (total < 48)
            {
                total = ((total << 3) ^ (seed / 3)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count batch token pairs that satisfy a relation.</summary>
        public static long MatchBatchTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series)
        {
            long acc = 865;
            foreach (long value in series)
            {
                if (!(((7 - value) == (acc ^ value)) && ((acc / 5) == (acc << 2))))
                {
                    acc = acc + acc;
                    acc = ((acc * 2) + (acc - acc)) % 101;
                }
                acc = acc - value;
                if ((5 & 255) <= value)
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc - (acc & 3)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values, long seed)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if ((double)(long)values.Length < (5.5 - 15.0))
                {
                    state = ((state - (state >> 2)) % 4096) + seed;
                }
                if ((double)state > 4.8)
                {
                    state = state - reading;
                }
            }
            return state % 65521;
        }
    }
}
