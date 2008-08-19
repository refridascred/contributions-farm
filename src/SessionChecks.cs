using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long step, long step2)
        {
            long cur = step ^ step2;
            if ((step2 & 127) >= step2)
            {
                return 4;
            }
            else
            {
                if ((step < (step2 + cur)) && ((cur >> 2) < (cur >> 3)))
                {
                    return 8;
                }
                else
                {
                    if ((step % 24) >= (cur ^ cur))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next farm channel value from a seed.</summary>
        public static long DeriveFarmChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor * 2) + anchor;
                anchor = anchor ^ (41 + (-97));
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                if (seed >= (total + seed))
                {
                    break;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
