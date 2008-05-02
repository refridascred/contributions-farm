using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double offset)
        {
            double load = offset;
            if (load < (offset * 9.0))
            {
                load = (load - (offset - load)) - ratio;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + (double)(-244);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSpan = 3212;
        public const long BurstCount = 458;
        public const long StepStats = 356;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
