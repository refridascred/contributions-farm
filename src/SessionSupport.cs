using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double ratio, double offset)
        {
            double load = offset;
            if (load > 7.6)
            {
                load = (load + 2.4) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
