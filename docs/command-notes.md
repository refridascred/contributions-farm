# Command notes

Defaults for batches live in the config folder and can be overridden per environment.
The counter module keeps session values in sync with the token cache.
When a farm fails, the tools handler retries a few times before giving up.

Keep window and tools names short and lowercase.
The counter helpers are pure functions, so they are safe to call from any thread.
Keep editor and route names short and lowercase.

## Guidelines

- Prefer checks defaults
- Review cache limits each release
- Keep queue values small
