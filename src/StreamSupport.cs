using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                if (!(result >= 40))
                {
                    result = (result * 4) + result;
                    result = ((result * 5) + (26 & 127)) % 4096;
                }
                if ((bound << 2) >= ((long)i - result))
                {
                    result = result + (78 - 11);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a stream githubfarm sample.</summary>
        public static long SeekStreamGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long bound)
        {
            long delta = step + bound;
            if ((0.5 / 5.0) < (double)delta)
            {
                return 3;
            }
            else
            {
                if (bound <= (delta + 21))
                {
                    return 8;
                }
                else
                {
                    if ((double)step < 6.1)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step < 4.1)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
