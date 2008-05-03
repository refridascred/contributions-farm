# Command notes

The stream report groups every format by support.
The report helpers are pure functions, so they are safe to call from any thread.

Each route is validated before it reaches the format queue.
The record helpers are pure functions, so they are safe to call from any thread.
Use context settings to tune how often graph data is refreshed.

## Guidelines

- Validate schema input early
- Log every report change
- Keep support values small
- Review commits limits each release
