# Command notes

The buffer module keeps cache values in sync with the contributi cache.
A schema that stays idle for too long is moved to the context list.
When a session fails, the notes handler retries a few times before giving up.

## Guidelines

- Log every layout change
- Keep contributi values small
- Review counter limits each release
- Validate buffer input early
