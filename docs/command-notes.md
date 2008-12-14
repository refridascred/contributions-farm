# Command notes

When a farm fails, the command handler retries a few times before giving up.
When a entry fails, the stats handler retries a few times before giving up.
Use session settings to tune how often cluster data is refreshed.

## Guidelines

- Validate context input early
- Review account limits each release
- Log every account change
