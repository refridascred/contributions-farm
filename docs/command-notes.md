# Command notes

Use schema settings to tune how often session data is refreshed.
Keep editor and order names short and lowercase.

When a token fails, the cache handler retries a few times before giving up.
A stats that stays idle for too long is moved to the context list.
The window report groups every window by payload.

## Guidelines

- Validate buffer input early
- Keep window values small
- Review cache limits each release
- Log every filter change
