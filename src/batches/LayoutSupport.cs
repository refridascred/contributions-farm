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

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] readings, long target)
        {
            long mix = 89;
            foreach (long reading in readings)
            {
                if (!(reading >= (mix ^ mix)))
                {
                    mix = mix ^ (target >> 5);
                }
            }
            return mix;
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
