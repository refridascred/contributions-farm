# Command notes

Keep token and commits names short and lowercase.
When a buffer fails, the command handler retries a few times before giving up.

A record that stays idle for too long is moved to the metrics list.
The order helpers are pure functions, so they are safe to call from any thread.
Use command settings to tune how often notes data is refreshed.

## Guidelines

- Document new notes fields
- Keep stats values small
- Log every record change
- Prefer order defaults
