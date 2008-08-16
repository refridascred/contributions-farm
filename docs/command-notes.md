# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
A filter that stays idle for too long is moved to the channel list.
When a cache fails, the contributi handler retries a few times before giving up.

## Guidelines

- Document new payload fields
- Review route limits each release
- Validate cache input early
- Keep metric values small
