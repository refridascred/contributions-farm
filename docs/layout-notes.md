# Layout notes

The schema helpers are pure functions, so they are safe to call from any thread.
A checks that stays idle for too long is moved to the graph list.

## Guidelines

- Log every cache change
- Keep context values small
- Review session limits each release
- Prefer entry defaults
