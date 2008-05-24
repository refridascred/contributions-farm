# Command notes

When a route fails, the channel handler retries a few times before giving up.
Each graph is validated before it reaches the buffer queue.
Keep schema and order names short and lowercase.

Each command is validated before it reaches the route queue.
When a report fails, the stats handler retries a few times before giving up.
The counter module keeps metrics values in sync with the session cache.

## Guidelines

- Log every window change
- Review report limits each release
- Prefer queue defaults
