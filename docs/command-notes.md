# Command notes

Use notes settings to tune how often format data is refreshed.
When a layout fails, the filter handler retries a few times before giving up.
A stream that stays idle for too long is moved to the counter list.

The filter module keeps counter values in sync with the already cache.
The metric module keeps commits values in sync with the command cache.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer payload defaults
- Document new editor fields
- Log every metrics change
- Review stats limits each release
