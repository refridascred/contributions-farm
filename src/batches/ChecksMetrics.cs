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

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] readings, long limit)
        {
            long mix = 809;
            foreach (long datum in readings)
            {
                if ((mix >= (mix + mix)) && (((-9) - (-35)) <= (datum + mix)))
                {
                    mix = ((mix + (mix >> 3)) % 101) + limit;
                }
            }
            return mix;
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
