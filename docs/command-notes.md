# Command notes

The metrics report groups every batches by commits.
When a schema fails, the report handler retries a few times before giving up.
Run the schema check before changing any counter limits.

Each payload is validated before it reaches the editor queue.
Use layout settings to tune how often account data is refreshed.
A buffer that stays idle for too long is moved to the report list.

## Guidelines

- Review stats limits each release
- Validate farm input early
- Prefer format defaults
- Keep counter values small
