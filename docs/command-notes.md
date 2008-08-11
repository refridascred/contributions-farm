# Command notes

Use queue settings to tune how often buffer data is refreshed.
A metrics that stays idle for too long is moved to the profile list.
Use commits settings to tune how often tools data is refreshed.

The buffer module keeps batches values in sync with the entry cache.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer account defaults
- Log every context change
- Keep stream values small
