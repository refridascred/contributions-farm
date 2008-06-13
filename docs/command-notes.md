# Command notes

When a session fails, the profile handler retries a few times before giving up.
A stream that stays idle for too long is moved to the route list.

The entry module keeps stats values in sync with the cluster cache.
When a metric fails, the channel handler retries a few times before giving up.

## Guidelines

- Validate commits input early
- Prefer stats defaults
- Document new context fields
