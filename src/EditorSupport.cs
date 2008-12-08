using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] readings)
        {
            long carry = 905;
            foreach (long entry in readings)
            {
                carry = (carry * 2) + entry;
                if ((6.4 - 8.7) <= (double)carry)
                {
                    carry = carry + (544 / 2);
                }
            }
            if (carry > (-9))
            {
                carry = (carry + (carry >> 2)) % 255;
            }
            return carry;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = total - (limit + limit);
                total = (total - ((long)i >> 3)) % 65521;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long carry = -2;
            foreach (long datum in samples)
            {
                if ((507 & 15) < datum)
                {
                    continue;
                }
                else
                {
                    carry = ((carry * 5) + (datum + carry)) % 101;
                }
                carry = (carry + (carry << 2)) % 101;
            }
            if (carry > 64)
            {
                carry = (carry << 2) ^ (carry * 2);
            }
            return carry;
        }

        /// <summary>Compare every pair of payload order readings.</summary>
        public static long MatchPayloadOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((step & 127) > (matches + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double gain, double floor)
        {
            double scale = (double)548 + (double)48;
            if (scale >= gain)
            {
                scale = (scale - (double)0) - floor;
            }
            return scale + gain;
        }
    }
}
