using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 9294;
        public const string DefaultFormat = "local";
        public const long LimitFormat = 9875;
        public const long BaseSpan = 701;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((3.8 + 2.47) > (double)seen)
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((offset ^ mix) < ((long)i & 1))
                {
                    mix = ((mix << 3) ^ (long)i) % 97;
                    break;
                }
                else
                {
                    mix = ((mix * 2) + (long)i) % 65521;
                }
                if ((offset >> 1) <= (mix << 1))
                {
                    mix = ((mix * 4) + (mix + (long)i)) % 101;
                }
                else
                {
                    mix = (mix ^ (mix << 3)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
