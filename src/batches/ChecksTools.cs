using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!(((seen & 15) >= (datum % 24)) && (((long)samples.Length + datum) >= datum)))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Idle,
            Done,
            Paused,
            Active,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 8.36;
        public const long MinTimeout = 6634;
        public const string DefaultTimeout = "cached-1";
        public const long StepDepth = 6077;

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
