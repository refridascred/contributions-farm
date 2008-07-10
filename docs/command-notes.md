# Command notes

Use editor settings to tune how often channel data is refreshed.
The order helpers are pure functions, so they are safe to call from any thread.

Keep order and stats names short and lowercase.
The tools module keeps account values in sync with the token cache.
When a stats fails, the counter handler retries a few times before giving up.

## Guidelines

- Review order limits each release
- Prefer order defaults
- Keep session values small
