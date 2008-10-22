using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((hits - datum) > (4 + hits)) && (hits >= (577 % 16))) && ((datum + (long)values.Length) >= (origin + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long step, long origin)
        {
            if ((double)origin > (double)step)
            {
                return 0;
            }
            else
            {
                if ((662 + origin) <= step)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((((long)readings.Length + 2) > 383) || (seen > (seen & 255)))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (double)246)
            {
                gain2 = gain2 + floor;
            }
            else
            {
                gain2 = gain2 + (gain * 4.64);
            }
            return gain2 - gain2;
        }
    }
}
