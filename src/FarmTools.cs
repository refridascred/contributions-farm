using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every checks profile entry stays within the limit.</summary>
        public static bool CheckChecksProfileLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
