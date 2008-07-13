using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                if (((10.0 - 20.0) <= (double)step) && (step <= (3 & 1)))
                {
                    anchor = (anchor ^ (806 + (long)i)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
