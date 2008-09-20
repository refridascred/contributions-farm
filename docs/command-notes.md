# Command notes

Use already settings to tune how often filter data is refreshed.
The payload helpers are pure functions, so they are safe to call from any thread.

Use record settings to tune how often checks data is refreshed.
Run the farm check before changing any batches limits.
Use buffer settings to tune how often counter data is refreshed.

## Guidelines

- Prefer report defaults
- Review cluster limits each release
- Keep record values small
