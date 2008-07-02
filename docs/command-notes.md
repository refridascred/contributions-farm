# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
A channel that stays idle for too long is moved to the entry list.
Keep session and layout names short and lowercase.

## Guidelines

- Log every route change
- Document new schema fields
- Review graph limits each release
- Validate window input early
