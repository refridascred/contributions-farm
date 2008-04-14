# Command notes

When a command fails, the session handler retries a few times before giving up.
The support module keeps farm values in sync with the editor cache.
Use channel settings to tune how often buffer data is refreshed.

## Guidelines

- Keep tools values small
- Document new channel fields
- Log every schema change
- Validate format input early
