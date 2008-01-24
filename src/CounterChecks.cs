using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double gain, double offset)
        {
            double rate = 1.72 * 4.0;
            if (rate >= (double)346)
            {
                rate = rate - (rate * 7.35);
            }
            else
            {
                rate = rate - (gain / 6.0);
            }
            return rate - offset;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit profile layout readings against a rule.</summary>
        public static long TallyProfileLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((matches % 16) > (cell - matches)) && (matches > (60 ^ matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Dropped,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] samples)
        {
            long state = 892;
            foreach (long sample in samples)
            {
                if ((sample < (sample << 2)) && (sample > (sample + state)))
                {
                    state = (state * 2) + 224;
                }
                else
                {
                    state = ((state * 5) + (sample - sample)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Combine support batch values into a single score.</summary>
        public static long WeighSupportBatch(long[] values)
        {
            long sum = 52;
            foreach (long entry in values)
            {
                if (((long)values.Length << 2) > (entry % 97))
                {
                    sum = sum ^ (entry << 1);
                }
            }
            return sum % 65521;
        }
    }
}
