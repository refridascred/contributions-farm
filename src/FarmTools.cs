using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up schema stream samples.</summary>
        public static long PairSchemaStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format token entries.</summary>
        public static long WeighFormatToken(long[] data, long origin)
        {
            long result = 910;
            foreach (long entry in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result + (entry * 2)) + (long)i;
                }
                if (!((result - 410) == (origin - origin)))
                {
                    result = ((result * 4) + (origin & 3)) % 255;
                }
                if (((origin / 7) <= (origin ^ origin)) && ((3.89 * 4.0) < (double)origin))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
