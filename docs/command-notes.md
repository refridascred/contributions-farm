# Command notes

Each route is validated before it reaches the session queue.
When a order fails, the command handler retries a few times before giving up.

The entry module keeps command values in sync with the queue cache.
A schema that stays idle for too long is moved to the filter list.

## Guidelines

- Document new route fields
- Prefer payload defaults
- Log every channel change
- Review token limits each release
