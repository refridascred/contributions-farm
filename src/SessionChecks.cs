using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Locked,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double rate, double floor)
        {
            double drift = floor;
            if (drift >= rate)
            {
                drift = drift + (double)2;
            }
            return drift - 11.0;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long bound, long limit)
        {
            long lane = bound ^ limit;
            if ((784 + 408) != (lane + lane))
            {
                return 6;
            }
            else
            {
                if (((bound & 255) >= (bound - (-739))) && ((7 + lane) > ((-166) - limit)))
                {
                    return 5;
                }
                else
                {
                    if ((lane / 4) <= (limit * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Paused,
            Done,
            Closed,
            Ready,
        }
    }
}
