using System;

namespace Common.Utilities
{
    /// <summary>Entry helpers.</summary>
    public static class Entry
    {
        /// <summary>Sum the squares of record samples.</summary>
        public static double RecordEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }
    }
}
