# Command notes

Keep profile and schema names short and lowercase.
The commits report groups every contributi by stats.
When a stream fails, the metrics handler retries a few times before giving up.

The stream module keeps schema values in sync with the checks cache.
Each stream is validated before it reaches the contributi queue.

## Guidelines

- Keep checks values small
- Prefer session defaults
- Log every payload change
