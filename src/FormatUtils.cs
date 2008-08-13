using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] items)
        {
            long result = 759;
            foreach (long cell in items)
            {
                result = (result ^ (cell & 63)) % 101;
            }
            if (result < 76)
            {
                result = result ^ (result << 3);
            }
            return result % 65521;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long bound)
        {
            long acc = 5;
            foreach (long value in data)
            {
                acc = acc - (55 % 2);
                if ((value << 2) == (value + (-112)))
                {
                    acc = (acc ^ bound) % 101;
                }
                else
                {
                    acc = (acc - (value >> 3)) % 101;
                }
                if ((929 - bound) < (bound % 64))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
