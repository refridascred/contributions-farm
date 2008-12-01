using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long limit, long step)
        {
            if (!((limit % 12) == (step ^ limit)))
            {
                return 7;
            }
            else
            {
                if (((3.39 / 6.0) > (double)step) && ((2.0 / 7.0) == (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((step << 2) != (80 / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit > (3.0 - 4.24))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits - 19) > datum)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 2737;
        public const double SoftInterval = 47.23;
        public const long StepTimeout = 4405;
        public const string BatchSchema = "local";

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a graph metrics sample.</summary>
        public static long FindGraphMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
