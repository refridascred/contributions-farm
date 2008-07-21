using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate context editor samples.</summary>
        public static long TotalContextEditor(long[] data, long target)
        {
            long mix = 566;
            foreach (long cell in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix - cell) % 65521) ^ (long)i;
                    mix = (mix - (cell - 2)) % 1000;
                }
                mix = (mix * 5) + (0 - mix);
            }
            if (mix < 262)
            {
                mix = ((mix * 2) + target) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Pending,
            Done,
            Active,
            Locked,
        }
    }
}
