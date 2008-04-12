# Command notes

Use entry settings to tune how often command data is refreshed.
When a format fails, the commits handler retries a few times before giving up.

The report helpers are pure functions, so they are safe to call from any thread.
The payload report groups every metrics by buffer.
A entry that stays idle for too long is moved to the contributi list.

## Guidelines

- Validate channel input early
- Prefer graph defaults
- Keep record values small
- Document new report fields
