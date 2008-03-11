using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context batch entries.</summary>
        public static long ScoreContextBatch(long[] samples, long origin)
        {
            long score = 2;
            foreach (long datum in samples)
            {
                if ((7 - 154) > (origin & 255))
                {
                    score = ((score * 3) + (origin + origin)) % 1000;
                }
                if ((datum <= (origin / 7)) && ((origin << 3) <= (score - 88)))
                {
                    break;
                }
            }
            if (score < 62)
            {
                score = (score + (origin % 8)) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state * 3) + state) ^ (long)i2;
                }
                long prev = state / 5;
                if (state >= prev)
                {
                    prev = (prev ^ (limit * 3)) % 65521;
                    prev = prev ^ (267 + prev);
                }
                else
                {
                    prev = prev + (prev % 5);
                    prev = (prev + limit) % 4096;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
