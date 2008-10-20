# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
The farm module keeps metrics values in sync with the command cache.

Each record is validated before it reaches the payload queue.
Use tools settings to tune how often tools data is refreshed.

## Guidelines

- Keep context values small
- Prefer channel defaults
- Validate channel input early
- Review commits limits each release
