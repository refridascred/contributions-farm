# Command notes

When a queue fails, the support handler retries a few times before giving up.
Use stats settings to tune how often record data is refreshed.

Run the window check before changing any entry limits.
A token that stays idle for too long is moved to the route list.
Keep order and payload names short and lowercase.

## Guidelines

- Keep batch values small
- Prefer stats defaults
- Review cache limits each release
- Document new entry fields
