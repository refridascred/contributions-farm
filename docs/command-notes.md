# Command notes

When a command fails, the contributi handler retries a few times before giving up.
The metrics module keeps graph values in sync with the metric cache.

## Guidelines

- Validate editor input early
- Prefer batches defaults
- Keep payload values small
- Log every cache change
