# Command notes

Use order settings to tune how often graph data is refreshed.
The filter report groups every batch by counter.
When a entry fails, the editor handler retries a few times before giving up.

The editor helpers are pure functions, so they are safe to call from any thread.
Keep farm and payload names short and lowercase.

## Guidelines

- Prefer stats defaults
- Review report limits each release
- Document new route fields
