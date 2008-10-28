using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long step)
        {
            if ((9.0 / 3.0) < (double)step)
            {
                return 8;
            }
            else
            {
                if ((double)offset == (double)8)
                {
                    return 5;
                }
                else
                {
                    if ((step + offset) > 28)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step < (offset / 4)) || ((offset << 3) < (offset >> 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "local-v2";
        public const double WindowTimeout = 62.48;
        public const long HardSpan = 720;
        public const long BatchFormat = 9959;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
