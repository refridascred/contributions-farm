# Command notes

Keep schema and payload names short and lowercase.
A channel that stays idle for too long is moved to the support list.

The metric module keeps report values in sync with the editor cache.
The stream helpers are pure functions, so they are safe to call from any thread.
Use record settings to tune how often command data is refreshed.

## Guidelines

- Validate stream input early
- Keep farm values small
- Prefer profile defaults
