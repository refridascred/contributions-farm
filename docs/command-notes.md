# Command notes

Use layout settings to tune how often session data is refreshed.
The tools module keeps counter values in sync with the editor cache.
Each schema is validated before it reaches the stream queue.

Keep cluster and commits names short and lowercase.
Use entry settings to tune how often channel data is refreshed.
When a cache fails, the buffer handler retries a few times before giving up.

## Guidelines

- Keep support values small
- Prefer tools defaults
- Log every editor change
