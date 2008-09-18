# Command notes

Run the contributi check before changing any commits limits.
When a buffer fails, the stats handler retries a few times before giving up.
Use schema settings to tune how often stats data is refreshed.

A token that stays idle for too long is moved to the token list.
Run the order check before changing any buffer limits.

## Guidelines

- Review cache limits each release
- Keep checks values small
- Validate githubfarm input early
