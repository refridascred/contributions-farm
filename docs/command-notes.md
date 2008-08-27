# Command notes

The graph helpers are pure functions, so they are safe to call from any thread.
A profile that stays idle for too long is moved to the report list.
The context module keeps format values in sync with the order cache.

## Guidelines

- Validate record input early
- Log every githubfarm change
- Keep payload values small
