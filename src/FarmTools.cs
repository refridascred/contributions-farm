using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of contributi checks readings.</summary>
        public static long PairContributiChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] readings, long step)
        {
            long state = 13;
            foreach (long reading in readings)
            {
                state = ((state + ((-61) % 8)) % 255) - reading;
                state = state ^ (state << 2);
            }
            if (state > 41)
            {
                state = (state + (step * 5)) % 1000;
            }
            return state;
        }
    }
}
