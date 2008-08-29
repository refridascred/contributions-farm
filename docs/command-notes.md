# Command notes

Run the counter check before changing any report limits.
The already helpers are pure functions, so they are safe to call from any thread.

Use stream settings to tune how often stream data is refreshed.
Keep editor and checks names short and lowercase.
When a metric fails, the editor handler retries a few times before giving up.

## Guidelines

- Keep queue values small
- Log every counter change
- Validate support input early
