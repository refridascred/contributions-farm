# Command notes

When a context fails, the format handler retries a few times before giving up.
Each format is validated before it reaches the already queue.
Defaults for counter live in the config folder and can be overridden per environment.

A filter that stays idle for too long is moved to the channel list.
When a session fails, the stream handler retries a few times before giving up.

## Guidelines

- Document new route fields
- Review support limits each release
- Log every channel change
- Validate tools input early
