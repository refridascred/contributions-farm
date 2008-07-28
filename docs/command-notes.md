# Command notes

Run the schema check before changing any payload limits.
When a route fails, the format handler retries a few times before giving up.
Use metrics settings to tune how often stats data is refreshed.

The tools module keeps report values in sync with the report cache.
Run the metrics check before changing any channel limits.
Each format is validated before it reaches the payload queue.

## Guidelines

- Keep tools values small
- Prefer report defaults
- Log every filter change
- Validate counter input early
