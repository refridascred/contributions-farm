using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long target, long floor)
        {
            long edge = target - floor;
            if (!((double)target >= (9.0 / 3.0)))
            {
                return 3;
            }
            else
            {
                if ((3 << 3) > (floor >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((target + target) <= edge)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data)
        {
            long anchor = 0;
            foreach (long datum in data)
            {
                if ((380 >> 2) != (anchor ^ anchor))
                {
                    anchor = (anchor ^ datum) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] readings, long seed)
        {
            long score = 6;
            foreach (long reading in readings)
            {
                score = (score * 3) + (reading * 5);
                if ((score * 5) < (602 & 15))
                {
                    score = score + reading;
                }
                else
                {
                    score = score - (seed - seed);
                }
            }
            return score;
        }
    }
}
