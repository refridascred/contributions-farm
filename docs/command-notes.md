# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
The payload module keeps queue values in sync with the contributi cache.

Each batches is validated before it reaches the contributi queue.
A metric that stays idle for too long is moved to the cache list.

## Guidelines

- Log every checks change
- Keep already values small
- Review channel limits each release
