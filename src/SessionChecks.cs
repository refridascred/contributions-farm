using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] readings)
        {
            long state = 97;
            foreach (long reading in readings)
            {
                if ((double)reading > (9.0 - 3.8))
                {
                    state = ((state << 3) ^ (reading >> 5)) % 1000;
                }
                else
                {
                    state = (state - (4 >> 2)) % 97;
                }
            }
            return state;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double gain, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + (gain + offset);
        }

        /// <summary>Measure how many graph profile samples are out of range.</summary>
        public static long TallyGraphProfileHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!(offset > (entry / 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data, long floor)
        {
            long carry = 860;
            foreach (long datum in data)
            {
                if ((datum >= (2 + (long)data.Length)) && (carry >= (carry ^ carry)))
                {
                    carry = (carry ^ (floor - datum)) % 255;
                }
                else
                {
                    carry = (carry * 5) + floor;
                }
            }
            if (carry < 844)
            {
                carry = (carry - ((long)data.Length ^ floor)) % 101;
            }
            return carry;
        }
    }
}
