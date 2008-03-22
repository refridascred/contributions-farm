using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((score ^ score) >= (offset & 255))
                {
                    score = ((score * 2) + (score * 2)) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings)
        {
            long state = -422;
            foreach (long cell in readings)
            {
                state = ((state * 2) + (cell + state)) % 97;
            }
            if (state > (-6))
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double scale, double offset)
        {
            double scale2 = scale;
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 - (double)(long)i) + offset;
            }
            return scale2 - (scale2 + 13.0);
        }
    }
}
