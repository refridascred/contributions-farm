# Command notes

When a batches fails, the metric handler retries a few times before giving up.
The stream module keeps context values in sync with the format cache.
Run the batches check before changing any session limits.

Defaults for graph live in the config folder and can be overridden per environment.
When a contributi fails, the stats handler retries a few times before giving up.

## Guidelines

- Validate order input early
- Log every format change
- Review buffer limits each release
