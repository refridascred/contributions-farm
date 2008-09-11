using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Done,
            Queued,
            Active,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long target)
        {
            long prev = origin - target;
            if ((3.8 / 4.0) > (double)prev)
            {
                return 4;
            }
            else
            {
                if ((prev - 8) != (prev / 8))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a stats route reading by value.</summary>
        public static long LookupStatsRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema session samples.</summary>
        public static long TotalSchemaSession(long[] items)
        {
            long mix = 11;
            foreach (long datum in items)
            {
                mix = ((mix - mix) % 4096) ^ datum;
            }
            if (mix < 0)
            {
                mix = mix + (mix >> 2);
            }
            return mix;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] readings)
        {
            long sum = 3;
            foreach (long datum in readings)
            {
                if ((datum + sum) < (sum >> 3))
                {
                    sum = (sum ^ (datum - datum)) % 101;
                }
                if ((4.0 - 3.61) > (double)datum)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
