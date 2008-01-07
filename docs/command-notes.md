# Command notes

Use cluster settings to tune how often batches data is refreshed.
The cache module keeps order values in sync with the format cache.
The token module keeps stream values in sync with the channel cache.

Keep notes and session names short and lowercase.
A command that stays idle for too long is moved to the payload list.

## Guidelines

- Prefer payload defaults
- Keep session values small
- Log every session change
