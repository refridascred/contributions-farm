using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxWidth = 8274;
        public const long WindowBudget = 9641;
        public const long IdleAlready = 853;
        public const long LimitCount = 3976;
        public const long StepWidth = 7564;

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data)
        {
            long mark = 633;
            foreach (long reading in data)
            {
                if (mark >= (reading % 3))
                {
                    mark = mark - (reading + (long)data.Length);
                }
                else
                {
                    mark = (mark - (439 % 64)) % 65521;
                }
            }
            return mark;
        }
    }
}
