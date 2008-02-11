# Command notes

When a report fails, the batch handler retries a few times before giving up.
A route that stays idle for too long is moved to the cache list.

## Guidelines

- Prefer batch defaults
- Review metric limits each release
- Log every order change
- Document new layout fields
