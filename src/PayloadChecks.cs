using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Rank { get; set; }
            public bool Score { get; set; }
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (4.4 / 5.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream queue readings.</summary>
        public static long DigestStreamQueue(long[] readings)
        {
            long total = 154;
            foreach (long item in readings)
            {
                if (item > (total + 88))
                {
                    total = ((total * 4) + (total + total)) % 65521;
                }
                else
                {
                    total = ((total * 5) + (0 / 8)) % 1000;
                    total = total + item;
                }
                if (((5.1 + 2.17) >= (double)total) || ((double)total == (9.9 - 8.65)))
                {
                    total = (total ^ (item + total)) % 4096;
                }
            }
            if (total < (-14))
            {
                total = (total * 2) + (8 + total);
            }
            return total;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] series)
        {
            long total = -291;
            foreach (long cell in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total + (cell >> 3)) % 65521) + (long)i;
                    total = (total << 2) ^ (total << 2);
                }
                total = ((total << 2) ^ (cell + total)) % 255;
                if (((total + cell) != (cell * 2)) || ((double)total >= (1.28 * 8.85)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 9131;
        public const long DefaultInterval = 1520;
        public const long MaxAlready = 4437;
        public const long StepAlready = 9429;
    }
}
