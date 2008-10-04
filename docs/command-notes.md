# Command notes

Use schema settings to tune how often counter data is refreshed.
The filter module keeps token values in sync with the entry cache.
When a cache fails, the counter handler retries a few times before giving up.

Run the channel check before changing any buffer limits.
A editor that stays idle for too long is moved to the stream list.
Use route settings to tune how often queue data is refreshed.

## Guidelines

- Validate profile input early
- Prefer batches defaults
- Review editor limits each release
- Log every metric change
