using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = mix ^ (mix % 97);
                mix = (mix - (floor * 5)) % 97;
                if (((long)i + mix) <= (mix & 15))
                {
                    mix = ((mix * 4) + (mix >> 5)) % 101;
                }
                else
                {
                    mix = mix ^ (mix ^ 72);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
