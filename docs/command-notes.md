# Command notes

The cluster report groups every profile by route.
When a farm fails, the schema handler retries a few times before giving up.

Run the payload check before changing any filter limits.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate stream input early
- Log every already change
- Document new checks fields
