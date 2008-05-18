# Command notes

A farm that stays idle for too long is moved to the already list.
A cluster that stays idle for too long is moved to the cache list.

A report that stays idle for too long is moved to the session list.
When a editor fails, the support handler retries a few times before giving up.
Keep format and counter names short and lowercase.

## Guidelines

- Log every session change
- Keep cluster values small
- Validate queue input early
- Review layout limits each release
