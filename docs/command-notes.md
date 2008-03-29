# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
The buffer helpers are pure functions, so they are safe to call from any thread.
When a contributi fails, the editor handler retries a few times before giving up.

## Guidelines

- Review layout limits each release
- Validate checks input early
- Log every schema change
