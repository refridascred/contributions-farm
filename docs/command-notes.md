# Command notes

Each context is validated before it reaches the channel queue.
The payload report groups every checks by counter.

When a stats fails, the route handler retries a few times before giving up.
The tools module keeps notes values in sync with the support cache.

## Guidelines

- Review contributi limits each release
- Document new stream fields
- Prefer buffer defaults
