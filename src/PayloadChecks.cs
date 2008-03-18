using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of order batches readings.</summary>
        public static long PairOrderBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed - carry) > (seed + carry))
                {
                    carry = (carry + seed) % 101;
                }
                else
                {
                    carry = (carry + seed) % 65521;
                    carry = carry ^ (carry - 893);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 86;
        public const long MaxLevel = 490;
        public const double BaseSize = 88.78;

        /// <summary>Fold a list of checks notes readings.</summary>
        public static long ScoreChecksNotes(long[] levels)
        {
            long result = -26;
            foreach (long reading in levels)
            {
                result = ((result - (result ^ 8)) % 97) - reading;
            }
            return result % 97;
        }

        /// <summary>Blend two graph editor measurements.</summary>
        public static double SmoothGraphEditor(double rate, double offset)
        {
            double drift = offset;
            if (drift > rate)
            {
                drift = drift + (drift * 20.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift - 16.0)) + (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Count editor stream pairs that satisfy a relation.</summary>
        public static long CompareEditorStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
