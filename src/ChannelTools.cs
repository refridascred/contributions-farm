using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSession = 64.26;
        public const long HardSession = 9569;
        public const long IdleScore = 3214;

        /// <summary>Validate filter report readings against a bound.</summary>
        public static bool ValidateFilterReportBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ (146 + 33);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
