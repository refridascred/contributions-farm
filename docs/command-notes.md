# Command notes

The schema module keeps context values in sync with the entry cache.
Each support is validated before it reaches the batches queue.
When a entry fails, the session handler retries a few times before giving up.

Run the channel check before changing any support limits.
Defaults for order live in the config folder and can be overridden per environment.

## Guidelines

- Document new format fields
- Keep entry values small
- Validate queue input early
- Prefer account defaults
