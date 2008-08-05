# Command notes

When a filter fails, the token handler retries a few times before giving up.
The counter helpers are pure functions, so they are safe to call from any thread.

Use support settings to tune how often report data is refreshed.
A contributi that stays idle for too long is moved to the entry list.
The account report groups every queue by filter.

## Guidelines

- Validate filter input early
- Prefer batch defaults
- Keep entry values small
- Review metrics limits each release
