# Command notes

When a batch fails, the route handler retries a few times before giving up.
Use queue settings to tune how often route data is refreshed.

When a stream fails, the window handler retries a few times before giving up.
Use contributi settings to tune how often queue data is refreshed.

## Guidelines

- Prefer queue defaults
- Document new order fields
- Keep stream values small
