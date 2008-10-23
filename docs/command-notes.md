# Command notes

The route module keeps account values in sync with the batch cache.
The report module keeps schema values in sync with the window cache.

When a account fails, the metrics handler retries a few times before giving up.
Keep contributi and support names short and lowercase.
Each layout is validated before it reaches the report queue.

## Guidelines

- Keep token values small
- Log every profile change
- Review commits limits each release
- Validate report input early
