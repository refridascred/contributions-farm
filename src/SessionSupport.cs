using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((bound >> 1) < 5)
                {
                    score = score ^ bound;
                }
                if ((18.0 / 5.0) == (double)bound)
                {
                    score = ((score * 4) + ((long)i >> 4)) % 255;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data)
        {
            long result = -616;
            foreach (long sample in data)
            {
                result = ((result ^ 839) % 255) ^ sample;
            }
            if (result > 775)
            {
                result = (result + (result + result)) % 65521;
            }
            return result;
        }
    }
}
