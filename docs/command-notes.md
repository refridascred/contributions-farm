# Command notes

Keep queue and cluster names short and lowercase.
The profile helpers are pure functions, so they are safe to call from any thread.
The queue module keeps commits values in sync with the order cache.

Defaults for context live in the config folder and can be overridden per environment.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate session input early
- Document new filter fields
- Keep metrics values small
- Review payload limits each release
