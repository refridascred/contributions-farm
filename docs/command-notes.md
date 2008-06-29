# Command notes

Run the batch check before changing any layout limits.
The report helpers are pure functions, so they are safe to call from any thread.

Use record settings to tune how often already data is refreshed.
When a farm fails, the cache handler retries a few times before giving up.
A layout that stays idle for too long is moved to the filter list.

## Guidelines

- Review metric limits each release
- Document new farm fields
- Log every layout change
