using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next token report value from a seed.</summary>
        public static long StepTokenReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i3 = 0; i3 < 12; i3++)
                {
                    result = (result ^ ((long)i & 7)) ^ (long)i3;
                    result = ((result * 5) + result) % 101;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Locked,
            Draft,
        }

        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long RollBatchSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = (result + ((long)i ^ (long)i)) % 1000;
                result = (result + floor) % 255;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
