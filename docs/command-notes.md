# Command notes

Keep schema and window names short and lowercase.
When a profile fails, the route handler retries a few times before giving up.
When a checks fails, the channel handler retries a few times before giving up.

Run the githubfarm check before changing any payload limits.
Use batch settings to tune how often report data is refreshed.

## Guidelines

- Log every filter change
- Prefer filter defaults
- Validate payload input early
- Document new command fields
