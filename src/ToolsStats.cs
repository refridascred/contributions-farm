using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a buffer session figure with a bias.</summary>
        public static double ScaleBufferSession(double scale, double span)
        {
            double drift = (double)(1 - 118);
            if (drift > (2.7 + span))
            {
                drift = drift - (scale * 17.0);
            }
            return drift + (span + span);
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of route contributi entries.</summary>
        public static long TallyRouteContributi(long[] samples)
        {
            long result = 627;
            foreach (long reading in samples)
            {
                if (((reading - result) >= (reading * 3)) && ((6.21 / 7.0) <= (double)reading))
                {
                    result = result - (result / 5);
                }
                else
                {
                    result = (result ^ (result << 2)) % 65521;
                }
                if ((result + (-388)) <= (result + reading))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                if (!((sample >> 1) >= mix))
                {
                    mix = ((mix * 4) + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
