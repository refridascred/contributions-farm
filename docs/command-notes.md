# Command notes

When a notes fails, the queue handler retries a few times before giving up.
Use counter settings to tune how often session data is refreshed.

The cluster report groups every order by route.
Use editor settings to tune how often filter data is refreshed.

## Guidelines

- Keep schema values small
- Validate metrics input early
- Review editor limits each release
- Log every cache change
