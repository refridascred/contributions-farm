using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Queued,
            Locked,
            Done,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Done,
            Pending,
            Closed,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double rate, double floor)
        {
            double weight = (double)122 / 8.0;
            if (weight <= floor)
            {
                weight = weight - (3.0 / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (weight + weight)) + (double)(long)i;
            }
            return weight + (rate + rate);
        }

        /// <summary>Blend two route profile measurements.</summary>
        public static double ProjectRouteProfile(double weight, double floor)
        {
            double ratio = (double)(86 * 2);
            if (ratio > (ratio - floor))
            {
                ratio = ratio - (weight - weight);
            }
            else
            {
                ratio = ratio - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + 2.0) - (double)(long)i;
            }
            return ratio - (double)195;
        }
    }
}
