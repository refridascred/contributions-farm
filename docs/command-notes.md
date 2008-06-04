# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
Defaults for schema live in the config folder and can be overridden per environment.
The queue report groups every contributi by layout.

Run the buffer check before changing any command limits.
The format module keeps stream values in sync with the payload cache.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Log every payload change
- Keep format values small
- Validate stream input early
- Review cluster limits each release
