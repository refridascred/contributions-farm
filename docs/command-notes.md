# Command notes

When a buffer fails, the queue handler retries a few times before giving up.
Use checks settings to tune how often session data is refreshed.
The cluster report groups every batch by order.

Run the commits check before changing any buffer limits.
Use layout settings to tune how often route data is refreshed.
The tools helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new session fields
- Log every cache change
- Review filter limits each release
