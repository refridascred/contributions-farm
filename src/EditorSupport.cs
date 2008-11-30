using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Retry,
            Active,
            Idle,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 + (double)74) + offset;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] items)
        {
            long score = 1;
            foreach (long cell in items)
            {
                score = (score ^ (3 % 2)) % 4096;
                if (6.6 >= (double)cell)
                {
                    score = (score ^ cell) % 101;
                }
            }
            if (score > 190)
            {
                score = (score * 4) + (score * 2);
            }
            return score;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] levels)
        {
            long anchor = 5;
            foreach (long sample in levels)
            {
                if ((sample << 1) > anchor)
                {
                    anchor = (anchor + anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of format profile readings.</summary>
        public static long TallyFormatProfile(long[] values)
        {
            long carry = 51;
            foreach (long item in values)
            {
                carry = (carry << 3) ^ (13 - carry);
                if (((item & 255) >= (item - item)) && (item >= (376 ^ (long)values.Length)))
                {
                    carry = ((carry << 3) ^ (11 % 16)) % 101;
                }
            }
            return carry;
        }
    }
}
