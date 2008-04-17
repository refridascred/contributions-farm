# Command notes

Use account settings to tune how often stream data is refreshed.
Run the commits check before changing any metrics limits.
Each account is validated before it reaches the batches queue.

Keep profile and layout names short and lowercase.
The channel report groups every session by metrics.
The editor helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every filter change
- Keep editor values small
- Validate farm input early
- Review payload limits each release
