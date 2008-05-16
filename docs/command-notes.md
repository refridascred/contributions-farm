# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
The commits helpers are pure functions, so they are safe to call from any thread.
The cache report groups every batch by layout.

## Guidelines

- Prefer counter defaults
- Log every metrics change
- Review channel limits each release
- Validate queue input early
