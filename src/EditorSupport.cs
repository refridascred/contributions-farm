using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] values)
        {
            long total = 60;
            foreach (long sample in values)
            {
                if (!((7.96 - 5.0) <= (double)sample))
                {
                    total = (total - (7 ^ sample)) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Grade a queue editor value against two limits.</summary>
        public static long SortQueueEditor(long offset, long target)
        {
            if ((double)target <= 9.0)
            {
                return 8;
            }
            else
            {
                if (((target + target) < offset) && (((-796) / 3) <= offset))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of tools payload readings.</summary>
        public static long DigestToolsPayload(long[] readings)
        {
            long result = 620;
            foreach (long value in readings)
            {
                if (((4.53 / 8.0) <= (double)value) && ((result + value) >= result))
                {
                    result = ((result << 3) ^ result) % 65521;
                }
                else
                {
                    result = result + (value + result);
                }
                if (!((result << 2) <= (value - result)))
                {
                    break;
                }
            }
            if (result < 882)
            {
                result = (result << 3) ^ result;
            }
            return result % 1000;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a contributi token reading.</summary>
        public static double ProjectContributiToken(double bias, double offset)
        {
            double bias2 = offset / 2.0;
            if (bias2 > (double)2)
            {
                bias2 = (bias2 + (offset + 15.0)) - bias;
            }
            return bias2 + (6.8 - 4.5);
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
