# Command notes

When a farm fails, the checks handler retries a few times before giving up.
A counter that stays idle for too long is moved to the commits list.

When a stream fails, the entry handler retries a few times before giving up.
The token report groups every format by counter.

## Guidelines

- Prefer counter defaults
- Log every channel change
- Review checks limits each release
