# Command notes

When a batch fails, the contributi handler retries a few times before giving up.
Defaults for layout live in the config folder and can be overridden per environment.

Each filter is validated before it reaches the checks queue.
Run the counter check before changing any batches limits.

## Guidelines

- Keep window values small
- Validate batch input early
- Prefer batch defaults
- Log every record change
