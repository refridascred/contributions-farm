# Command notes

Each profile is validated before it reaches the batches queue.
Run the token check before changing any already limits.
The metrics module keeps session values in sync with the batch cache.

Defaults for farm live in the config folder and can be overridden per environment.
A editor that stays idle for too long is moved to the contributi list.
A buffer that stays idle for too long is moved to the metrics list.

## Guidelines

- Validate buffer input early
- Review filter limits each release
- Keep already values small
- Prefer stats defaults
