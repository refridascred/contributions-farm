# Command notes

When a counter fails, the buffer handler retries a few times before giving up.
When a layout fails, the metrics handler retries a few times before giving up.

Use profile settings to tune how often graph data is refreshed.
A tools that stays idle for too long is moved to the farm list.

## Guidelines

- Log every stats change
- Document new graph fields
- Review notes limits each release
