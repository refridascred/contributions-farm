# Command notes

The window module keeps metric values in sync with the commits cache.
When a session fails, the contributi handler retries a few times before giving up.
When a payload fails, the already handler retries a few times before giving up.

## Guidelines

- Validate counter input early
- Keep token values small
- Review format limits each release
