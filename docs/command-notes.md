# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
The report report groups every batch by filter.
Use stats settings to tune how often counter data is refreshed.

Run the format check before changing any entry limits.
The editor helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate metrics input early
- Keep format values small
- Log every payload change
- Prefer report defaults
