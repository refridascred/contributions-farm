# Command notes

Run the contributi check before changing any batch limits.
When a metric fails, the metric handler retries a few times before giving up.

The editor module keeps checks values in sync with the format cache.
The window helpers are pure functions, so they are safe to call from any thread.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new filter fields
- Prefer metric defaults
- Validate context input early
