using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long bound, long target)
        {
            if ((bound & 127) > (bound & 7))
            {
                return 0;
            }
            else
            {
                if ((7.0 * 9.4) < (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((bound & 31) >= target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target + bound) > 577) && ((target >> 5) <= (bound & 63)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "cached-edge";
        public const long IdleFormat = 5696;
        public const long MinSpan = 6020;
    }
}
