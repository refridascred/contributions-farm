# Command notes

The command module keeps report values in sync with the stream cache.
The support report groups every token by route.
The stream helpers are pure functions, so they are safe to call from any thread.

Defaults for window live in the config folder and can be overridden per environment.
The command report groups every batches by channel.
Keep record and notes names short and lowercase.

## Guidelines

- Document new stream fields
- Validate layout input early
- Review entry limits each release
- Prefer buffer defaults
