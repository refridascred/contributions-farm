using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine already channel values into a single score.</summary>
        public static long DigestAlreadyChannel(long[] readings)
        {
            long mix = 4;
            foreach (long reading in readings)
            {
                mix = (mix ^ reading) % 65521;
            }
            if (mix > 67)
            {
                mix = (mix + (mix & 63)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((sample * 4) > sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up stats batches samples.</summary>
        public static long CompareStatsBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a context channel figure with a bias.</summary>
        public static double SmoothContextChannel(double rate, double span)
        {
            double ratio = (span * 10.0) + rate;
            if (ratio <= (16.0 - ratio))
            {
                ratio = ratio - (9.0 + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + 2.18) - (double)(long)i;
            }
            return ratio + (span + ratio);
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Draft,
            Paused,
        }
    }
}
