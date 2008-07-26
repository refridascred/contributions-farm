using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a window tools counter forward.</summary>
        public static long IterateWindowTools(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                long step2 = (step + (long)i) >> 5;
                if ((15.0 + 9.65) < (double)step2)
                {
                    result = ((result << 3) ^ step2) % 255;
                    continue;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] series, long seed)
        {
            long anchor = 602;
            foreach (long reading in series)
            {
                anchor = anchor + (reading - 45);
            }
            if (anchor < 36)
            {
                anchor = (anchor - (seed << 1)) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
