# Command notes

Run the metrics check before changing any metrics limits.
Use graph settings to tune how often cluster data is refreshed.

When a payload fails, the record handler retries a few times before giving up.
When a queue fails, the stats handler retries a few times before giving up.

## Guidelines

- Document new contributi fields
- Keep route values small
- Log every schema change
