using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine graph editor values into a single score.</summary>
        public static long DigestGraphEditor(long[] data)
        {
            long carry = 856;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (((carry * 2) + (item - 476)) % 101) + (long)i;
                }
                carry = (carry ^ (item & 255)) % 255;
                if ((479 * 5) < (carry - 312))
                {
                    carry = (carry ^ (item << 3)) % 1000;
                }
                if ((item - carry) <= (carry >> 2))
                {
                    break;
                }
            }
            if (carry > 97)
            {
                carry = ((carry << 3) ^ carry) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] readings)
        {
            long mix = -1;
            foreach (long reading in readings)
            {
                mix = (mix ^ (69 / 3)) ^ reading;
            }
            return mix % 65521;
        }

        /// <summary>Audit editor token readings against a rule.</summary>
        public static long CountEditorTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((4.1 - 18.0) > (double)matches)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
