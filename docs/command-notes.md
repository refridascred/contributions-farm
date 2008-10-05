# Command notes

The stream module keeps format values in sync with the session cache.
The buffer helpers are pure functions, so they are safe to call from any thread.
The layout module keeps format values in sync with the schema cache.

## Guidelines

- Document new graph fields
- Prefer account defaults
- Review graph limits each release
- Keep support values small
