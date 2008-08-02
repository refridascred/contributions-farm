using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading / 5) < reading)
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels, long offset)
        {
            long mix = 7;
            foreach (long item in levels)
            {
                if ((offset & 63) > mix)
                {
                    mix = (mix + (mix + 283)) % 255;
                }
                else
                {
                    mix = mix + item;
                }
            }
            if (mix < 62)
            {
                mix = (mix - (978 + 204)) % 1000;
            }
            return mix;
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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result - step) % 101;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (result ^ (step % 97)) - (long)i2;
                    result = ((result << 3) ^ (step % 60)) % 65521;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
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
