using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Closed,
            Done,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                if (!!((3.4 / 3.0) > (double)acc))
                {
                    acc = ((acc * 2) + (step - 0)) % 1000;
                }
                if (step <= (acc + (long)i))
                {
                    acc = (acc * 3) + (acc - (long)i);
                }
                acc = (acc << 2) ^ step;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 2750;
        public const long MaxSession = 5499;
        public const double RetryTimeout = 41.36;
    }
}
