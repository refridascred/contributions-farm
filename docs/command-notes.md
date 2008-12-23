# Command notes

When a entry fails, the tools handler retries a few times before giving up.
Keep order and stream names short and lowercase.
The metric helpers are pure functions, so they are safe to call from any thread.

Use schema settings to tune how often notes data is refreshed.
The metrics report groups every entry by cache.
Use counter settings to tune how often farm data is refreshed.

## Guidelines

- Prefer payload defaults
- Validate buffer input early
- Review schema limits each release
- Log every counter change
