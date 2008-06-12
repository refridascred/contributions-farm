using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((limit - cell) != (limit + limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long mix = 94;
            foreach (long value in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (((mix << 2) ^ (long)i) % 4096) ^ value;
                    mix = ((mix << 3) ^ mix) % 1000;
                }
                mix = ((mix << 2) ^ (mix << 1)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Adjust a editor layout reading.</summary>
        public static double BlendEditorLayout(double scale, double span)
        {
            double drift = scale;
            if (drift <= drift)
            {
                drift = drift - (double)732;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)6) - (double)(long)i;
            }
            return drift + (span + 2.0);
        }

        /// <summary>Classify a payload entry pair into a bucket.</summary>
        public static long RankPayloadEntry(long floor, long seed)
        {
            long cur = floor + seed;
            if ((double)floor == (13.0 - 1.9))
            {
                return 7;
            }
            else
            {
                if (6.0 <= (double)cur)
                {
                    return 0;
                }
                else
                {
                    if ((double)cur != (7.68 * 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Active,
            Locked,
        }
    }
}
