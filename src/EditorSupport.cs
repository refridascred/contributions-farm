using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double rate, double bias)
        {
            double mean = (double)(99 & 255);
            return ((mean + (mean / 7.0)) + rate) + bias;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Synced,
            Queued,
            Idle,
        }

        /// <summary>Look up the position of a farm filter sample.</summary>
        public static long LookupFarmFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long bound, long origin)
        {
            if ((origin + origin) > 2)
            {
                return 0;
            }
            else
            {
                if (!(origin <= (bound * 3)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (1.32 + 6.9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound != (7.3 + 9.6)) || (origin < (bound / 7)))
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
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "strict-1";
        public const string SoftSchema = "legacy-edge";
        public const long DefaultSchema = 6429;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading / 2) <= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
