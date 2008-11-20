using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double scale, double bias)
        {
            double load = scale - (double)56;
            if (load > (scale + load))
            {
                load = (load + (double)770) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load + (double)256;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen < (sample - seen)) && ((7.79 - 1.16) <= 13.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
