# Command notes

Keep route and context names short and lowercase.
The route report groups every filter by schema.
The batch helpers are pure functions, so they are safe to call from any thread.

The cluster report groups every filter by cache.
The window report groups every token by farm.
A route that stays idle for too long is moved to the session list.

## Guidelines

- Log every entry change
- Keep stats values small
- Review window limits each release
