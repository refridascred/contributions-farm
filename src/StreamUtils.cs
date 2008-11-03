using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Paused,
            Stale,
            Synced,
            Idle,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Queued,
            Done,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double bias, double bias2)
        {
            double drift = 3.82;
            if (drift >= (bias2 - bias2))
            {
                drift = (drift + bias2) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift / 6.0)) + (double)(long)i;
            }
            return drift - (drift * 9.4);
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((457 - tally) > seed)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
