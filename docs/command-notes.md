# Command notes

Each account is validated before it reaches the notes queue.
Keep notes and stats names short and lowercase.
Use notes settings to tune how often format data is refreshed.

Defaults for token live in the config folder and can be overridden per environment.
Run the tools check before changing any schema limits.
The commits helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new filter fields
- Prefer token defaults
- Review queue limits each release
- Log every format change
