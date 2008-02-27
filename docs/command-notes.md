# Command notes

Each channel is validated before it reaches the batches queue.
Use order settings to tune how often stream data is refreshed.

The channel module keeps stats values in sync with the session cache.
Each schema is validated before it reaches the farm queue.
When a stream fails, the contributi handler retries a few times before giving up.

## Guidelines

- Review stream limits each release
- Document new queue fields
- Keep token values small
- Prefer metric defaults
