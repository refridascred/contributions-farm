# Command notes

Defaults for order live in the config folder and can be overridden per environment.
Use editor settings to tune how often session data is refreshed.
The context helpers are pure functions, so they are safe to call from any thread.

The stats module keeps report values in sync with the buffer cache.
Keep farm and stream names short and lowercase.
The queue report groups every order by counter.

## Guidelines

- Keep format values small
- Review filter limits each release
- Validate record input early
- Prefer already defaults
