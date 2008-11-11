using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Ready,
            Draft,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] samples, long floor)
        {
            long result = 461;
            foreach (long reading in samples)
            {
                if (((5.9 / 2.0) < (double)result) || (reading < (result ^ result)))
                {
                    result = ((result - (reading + result)) % 4096) - floor;
                }
            }
            return result % 65521;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
