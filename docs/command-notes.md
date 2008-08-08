# Command notes

The contributi report groups every metric by stats.
Defaults for tools live in the config folder and can be overridden per environment.

The entry module keeps buffer values in sync with the context cache.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate filter input early
- Review channel limits each release
- Keep support values small
