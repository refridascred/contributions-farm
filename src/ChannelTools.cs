using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((-4) - offset) <= (total % 100))
                {
                    total = ((total * 4) + total) % 65521;
                }
                else
                {
                    total = total + offset;
                }
                long step = (total >> 1) & 7;
                total = ((total << 3) ^ (step + offset)) % 101;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of editor command entries.</summary>
        public static long WeighEditorCommand(long[] readings, long step)
        {
            long state = 59;
            foreach (long value in readings)
            {
                if (!((value + step) < 1))
                {
                    state = (state + (627 - value)) % 1000;
                }
            }
            if (state < 415)
            {
                state = (state - (step + state)) % 65521;
            }
            return state;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
