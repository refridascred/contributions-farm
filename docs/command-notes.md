# Command notes

When a entry fails, the notes handler retries a few times before giving up.
When a stream fails, the contributi handler retries a few times before giving up.
Use command settings to tune how often command data is refreshed.

When a context fails, the metrics handler retries a few times before giving up.
Use farm settings to tune how often entry data is refreshed.
Use stats settings to tune how often contributi data is refreshed.

## Guidelines

- Review already limits each release
- Log every record change
- Prefer format defaults
