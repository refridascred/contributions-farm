# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
Run the profile check before changing any stream limits.

Run the buffer check before changing any graph limits.
The context report groups every graph by commits.
The payload module keeps stream values in sync with the session cache.

## Guidelines

- Keep stats values small
- Prefer farm defaults
- Document new report fields
