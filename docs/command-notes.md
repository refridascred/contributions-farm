# Command notes

Keep schema and command names short and lowercase.
Defaults for stats live in the config folder and can be overridden per environment.
Run the stream check before changing any farm limits.

Keep farm and queue names short and lowercase.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer batch defaults
- Keep context values small
- Validate metric input early
- Review farm limits each release
