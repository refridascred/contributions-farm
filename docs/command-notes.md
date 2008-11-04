# Command notes

The buffer report groups every entry by tools.
Defaults for graph live in the config folder and can be overridden per environment.

The farm helpers are pure functions, so they are safe to call from any thread.
Keep batch and channel names short and lowercase.
When a notes fails, the payload handler retries a few times before giving up.

## Guidelines

- Review contributi limits each release
- Log every entry change
- Validate batches input early
