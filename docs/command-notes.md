# Command notes

The format module keeps metric values in sync with the report cache.
The command module keeps order values in sync with the batch cache.
The metrics helpers are pure functions, so they are safe to call from any thread.

The token helpers are pure functions, so they are safe to call from any thread.
The githubfarm report groups every graph by token.

## Guidelines

- Review buffer limits each release
- Keep window values small
- Prefer token defaults
