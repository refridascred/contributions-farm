using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first record tools entry that matches the target.</summary>
        public static long FindRecordToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long offset, long floor)
        {
            if ((floor << 2) == (floor & 31))
            {
                return 2;
            }
            else
            {
                if (!(((-394) % 8) > (offset ^ offset)))
                {
                    return 0;
                }
                else
                {
                    if (offset <= (floor % 60))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long origin)
        {
            if (12.0 < (double)target)
            {
                return 8;
            }
            else
            {
                if ((double)target >= 3.0)
                {
                    return 4;
                }
                else
                {
                    if (origin >= (origin - 79))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(2.83 >= (double)origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
