# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
The context report groups every command by commits.
When a record fails, the tools handler retries a few times before giving up.

The editor report groups every format by context.
The record module keeps schema values in sync with the route cache.
When a batch fails, the record handler retries a few times before giving up.

## Guidelines

- Review batch limits each release
- Document new context fields
- Validate window input early
