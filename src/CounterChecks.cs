using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double gain, double span)
        {
            double rate = span * 2.3;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (gain * 18.0)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchCount = 5233;
        public const long CacheChecks = 7424;
        public const long BurstChecks = 7530;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Token { get; set; } = "";
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long step, long floor)
        {
            long diff = step ^ floor;
            if (!(step <= (floor / 6)))
            {
                return 5;
            }
            else
            {
                if ((floor - floor) >= step)
                {
                    return 2;
                }
                else
                {
                    if (!((double)diff <= (5.2 + 18.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((10.0 - 1.85) > (double)diff) || ((diff + step) < step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up checks token samples.</summary>
        public static long OverlapChecksTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
