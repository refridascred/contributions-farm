# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
A githubfarm that stays idle for too long is moved to the entry list.

Use graph settings to tune how often tools data is refreshed.
Run the commits check before changing any schema limits.
The session helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer token defaults
- Keep context values small
- Validate record input early
