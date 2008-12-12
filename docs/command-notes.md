# Command notes

The payload report groups every checks by record.
A report that stays idle for too long is moved to the batch list.

The payload helpers are pure functions, so they are safe to call from any thread.
Use session settings to tune how often schema data is refreshed.

## Guidelines

- Log every account change
- Validate batch input early
- Prefer entry defaults
