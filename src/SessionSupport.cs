using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a already entry reading.</summary>
        public static double SmoothAlreadyEntry(double ratio, double offset)
        {
            double load = offset;
            if (load <= offset)
            {
                load = (load - (double)(-31)) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (7.98 + 4.26)) - (double)(long)i;
            }
            return load - offset;
        }
    }
}
