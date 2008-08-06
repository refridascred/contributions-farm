using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double ratio, double floor)
        {
            double weight = (double)5;
            if (weight >= floor)
            {
                weight = (weight + 4.0) - ratio;
            }
            return weight + (floor + floor);
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Pending,
            New,
            Active,
            Locked,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Done,
            Closed,
            Locked,
        }
    }
}
