using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long anchor = 458;
            foreach (long datum in items)
            {
                if ((anchor >= (anchor >> 4)) || ((anchor * 3) == (12 ^ 79)))
                {
                    anchor = ((anchor << 2) ^ ((-19) % 10)) - datum;
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of profile checks readings.</summary>
        public static long TallyProfileChecks(long[] levels)
        {
            long acc = 591;
            foreach (long value in levels)
            {
                acc = (acc - (value + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Accumulate order layout samples.</summary>
        public static long FoldOrderLayout(long[] series, long step)
        {
            long mark = 258;
            foreach (long value in series)
            {
                if (!(step > (step - 945)))
                {
                    mark = (((mark << 3) ^ (step / 5)) % 97) ^ value;
                }
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Queued,
            Failed,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Failed,
            Active,
            Closed,
            Draft,
        }
    }
}
