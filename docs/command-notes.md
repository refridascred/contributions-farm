# Command notes

Each buffer is validated before it reaches the order queue.
Use token settings to tune how often notes data is refreshed.
Keep channel and route names short and lowercase.

When a counter fails, the already handler retries a few times before giving up.
A stream that stays idle for too long is moved to the already list.

## Guidelines

- Prefer counter defaults
- Keep report values small
- Review layout limits each release
- Document new contributi fields
