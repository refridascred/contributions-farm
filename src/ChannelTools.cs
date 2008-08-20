using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine tools already values into a single score.</summary>
        public static long TallyToolsAlready(long[] readings)
        {
            long mix = 309;
            foreach (long sample in readings)
            {
                if (mix <= (mix / 8))
                {
                    mix = mix - sample;
                }
            }
            if (mix < 9)
            {
                mix = (mix * 4) + (mix >> 3);
            }
            return mix;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples, long floor)
        {
            long anchor = -15;
            foreach (long sample in samples)
            {
                if ((double)(long)samples.Length > (0.1 - 6.4))
                {
                    anchor = (((anchor * 5) + (sample & 255)) % 97) - floor;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - (carry - carry)) % 255;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
