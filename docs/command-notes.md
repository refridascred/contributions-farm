# Command notes

Keep notes and support names short and lowercase.
Run the contributi check before changing any support limits.
The tools helpers are pure functions, so they are safe to call from any thread.

Run the batch check before changing any context limits.
The schema module keeps record values in sync with the graph cache.
A batch that stays idle for too long is moved to the support list.

## Guidelines

- Prefer token defaults
- Log every channel change
- Validate record input early
- Review cache limits each release
