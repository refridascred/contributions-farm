using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine payload counter values into a single score.</summary>
        public static long ScorePayloadCounter(long[] samples, long step)
        {
            long mark = -1;
            foreach (long value in samples)
            {
                if ((mark / 2) > step)
                {
                    mark = (mark + (step + value)) % 101;
                    mark = (mark * 2) + (mark - value);
                }
                if (value >= (mark + mark))
                {
                    mark = mark ^ 251;
                }
                else
                {
                    mark = (mark + (long)samples.Length) % 101;
                }
            }
            return mark;
        }

        /// <summary>Count the farm format entries that pass the check.</summary>
        public static long AuditFarmFormatMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell <= (cell << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(((-4) + acc) <= (bound + bound)))
                {
                    acc = acc + (acc - acc);
                }
                acc = ((acc * 4) + (acc + bound)) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series, long bound)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                if ((8.0 - 9.0) != (double)mix)
                {
                    mix = ((((mix << 3) ^ (mix << 3)) % 4096) ^ cell) - bound;
                }
                else
                {
                    mix = mix - (mix ^ 11);
                }
            }
            return mix % 4096;
        }
    }
}
