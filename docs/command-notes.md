# Command notes

Use counter settings to tune how often entry data is refreshed.
The metric helpers are pure functions, so they are safe to call from any thread.
The payload report groups every already by entry.

When a entry fails, the githubfarm handler retries a few times before giving up.
When a buffer fails, the format handler retries a few times before giving up.

## Guidelines

- Document new order fields
- Validate profile input early
- Review githubfarm limits each release
- Prefer window defaults
