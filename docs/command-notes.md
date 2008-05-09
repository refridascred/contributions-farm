# Command notes

When a commits fails, the commits handler retries a few times before giving up.
Use context settings to tune how often session data is refreshed.

## Guidelines

- Keep cache values small
- Validate counter input early
- Log every graph change
