# Command notes

The farm module keeps entry values in sync with the command cache.
A context that stays idle for too long is moved to the stats list.
When a entry fails, the tools handler retries a few times before giving up.

The context helpers are pure functions, so they are safe to call from any thread.
Use cache settings to tune how often filter data is refreshed.

## Guidelines

- Log every contributi change
- Validate batches input early
- Document new entry fields
- Prefer route defaults
