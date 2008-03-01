using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((value - seen) != (value / 6)) || ((value * 3) <= seen)) && !(((-50) & 31) <= floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of context graph readings.</summary>
        public static long TotalContextGraph(long[] data)
        {
            long carry = 1;
            foreach (long datum in data)
            {
                carry = carry ^ ((long)data.Length & 63);
                carry = (carry << 2) ^ datum;
            }
            return carry;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = result ^ result;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 3) ^ ((long)i2 % 2)) % 1000;
                    result = (result << 3) ^ limit;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate notes buffer readings against a bound.</summary>
        public static bool ValidateNotesBufferBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cache notes readings against a rule.</summary>
        public static long AuditCacheNotesGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen & 127) < reading)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }
    }
}
