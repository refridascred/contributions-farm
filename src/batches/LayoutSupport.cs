using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next batch token value from a seed.</summary>
        public static long RollBatchToken(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                long step = mark;
                if (step <= (long)i)
                {
                    mark = (mark - (bound ^ mark)) % 1000;
                    step = step + (bound * 3);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long state = 64;
            foreach (long item in readings)
            {
                if ((double)item > (double)92)
                {
                    state = (state + state) % 101;
                }
            }
            return state;
        }

        /// <summary>Count format context pairs that satisfy a relation.</summary>
        public static long PairFormatContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] readings, long seed)
        {
            long mark = 56;
            foreach (long cell in readings)
            {
                mark = (mark - (seed << 3)) % 255;
                if (seed <= (seed - cell))
                {
                    mark = (mark * 2) + (mark / 8);
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Active,
            Draft,
        }
    }
}
