# Command notes

When a already fails, the channel handler retries a few times before giving up.
Use buffer settings to tune how often commits data is refreshed.
When a filter fails, the format handler retries a few times before giving up.

Use stream settings to tune how often layout data is refreshed.
A payload that stays idle for too long is moved to the farm list.
Use checks settings to tune how often order data is refreshed.

## Guidelines

- Validate notes input early
- Review account limits each release
- Prefer report defaults
- Document new contributi fields
