using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                if (2.81 < (double)(long)i)
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Active,
            Queued,
            Ready,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix - ((-9) * 5)) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
