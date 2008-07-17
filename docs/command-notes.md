# Command notes

The support report groups every window by channel.
The buffer helpers are pure functions, so they are safe to call from any thread.

A channel that stays idle for too long is moved to the report list.
The stats module keeps record values in sync with the token cache.

## Guidelines

- Review graph limits each release
- Document new window fields
- Validate farm input early
- Prefer format defaults
