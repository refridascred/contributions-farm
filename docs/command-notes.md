# Command notes

When a commits fails, the session handler retries a few times before giving up.
Use queue settings to tune how often format data is refreshed.

The counter report groups every format by stats.
Use queue settings to tune how often layout data is refreshed.
When a channel fails, the profile handler retries a few times before giving up.

## Guidelines

- Review buffer limits each release
- Validate filter input early
- Prefer context defaults
- Log every account change
