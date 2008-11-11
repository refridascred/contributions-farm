# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Use profile settings to tune how often batches data is refreshed.
The payload report groups every order by command.

## Guidelines

- Keep batches values small
- Review batches limits each release
- Prefer editor defaults
