# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
A report that stays idle for too long is moved to the counter list.
The format module keeps metrics values in sync with the contributi cache.

Use graph settings to tune how often schema data is refreshed.
Each stream is validated before it reaches the editor queue.
Keep command and channel names short and lowercase.

## Guidelines

- Document new session fields
- Validate schema input early
- Review payload limits each release
- Log every counter change
