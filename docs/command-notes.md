# Command notes

Run the record check before changing any entry limits.
Run the context check before changing any commits limits.
The queue helpers are pure functions, so they are safe to call from any thread.

A profile that stays idle for too long is moved to the already list.
The payload module keeps record values in sync with the queue cache.

## Guidelines

- Review contributi limits each release
- Document new stats fields
- Log every route change
- Prefer metrics defaults
