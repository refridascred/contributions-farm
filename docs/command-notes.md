# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Keep order and buffer names short and lowercase.
Each context is validated before it reaches the counter queue.

A notes that stays idle for too long is moved to the editor list.
Keep cache and channel names short and lowercase.
The cache module keeps graph values in sync with the already cache.

## Guidelines

- Log every payload change
- Review stats limits each release
- Document new queue fields
