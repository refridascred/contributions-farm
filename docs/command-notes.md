# Command notes

A githubfarm that stays idle for too long is moved to the route list.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review format limits each release
- Keep stream values small
- Log every route change
- Validate cluster input early
