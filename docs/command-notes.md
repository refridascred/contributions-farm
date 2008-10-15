# Command notes

When a metric fails, the already handler retries a few times before giving up.
When a commits fails, the command handler retries a few times before giving up.

## Guidelines

- Validate queue input early
- Prefer metrics defaults
- Log every stats change
