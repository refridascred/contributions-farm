# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
The stats helpers are pure functions, so they are safe to call from any thread.
A githubfarm that stays idle for too long is moved to the token list.

## Guidelines

- Review channel limits each release
- Log every route change
- Prefer session defaults
- Validate command input early
