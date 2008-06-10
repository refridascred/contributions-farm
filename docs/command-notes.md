# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
Keep batches and farm names short and lowercase.
Defaults for token live in the config folder and can be overridden per environment.

## Guidelines

- Log every payload change
- Review metrics limits each release
- Keep stream values small
