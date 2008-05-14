using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of route farm entries.</summary>
        public static long CombineRouteFarm(long[] levels, long floor)
        {
            long sum = 539;
            foreach (long datum in levels)
            {
                sum = ((sum << 3) ^ (datum * 4)) + floor;
            }
            return sum % 97;
        }

        /// <summary>Match up editor farm samples.</summary>
        public static long MatchEditorFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            New,
            Ready,
            Locked,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] readings, long floor)
        {
            long state = 3;
            foreach (long datum in readings)
            {
                if ((datum % 2) < ((-140) - 8))
                {
                    state = (state + (584 ^ datum)) % 255;
                }
            }
            if (state < 646)
            {
                state = ((state << 2) ^ (floor + state)) % 255;
            }
            return state;
        }

        /// <summary>Scale a window session figure with a bias.</summary>
        public static double SmoothWindowSession(double rate, double span)
        {
            double gain = rate / 7.0;
            if (gain > (double)81)
            {
                gain = (gain + 9.19) + span;
            }
            else
            {
                gain = gain + (rate - 0.8);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + 12.0;
        }
    }
}
