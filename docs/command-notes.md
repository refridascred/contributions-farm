# Command notes

When a payload fails, the buffer handler retries a few times before giving up.
When a contributi fails, the metrics handler retries a few times before giving up.

## Guidelines

- Log every layout change
- Review contributi limits each release
- Keep format values small
- Validate context input early
