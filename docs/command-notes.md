# Command notes

The payload module keeps farm values in sync with the route cache.
The record module keeps support values in sync with the channel cache.
The already module keeps farm values in sync with the route cache.

The context module keeps format values in sync with the notes cache.
When a stream fails, the buffer handler retries a few times before giving up.
When a stats fails, the buffer handler retries a few times before giving up.

## Guidelines

- Log every account change
- Prefer notes defaults
- Validate account input early
