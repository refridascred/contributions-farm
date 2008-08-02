# Command notes

Run the contributi check before changing any stats limits.
Run the queue check before changing any record limits.
Each queue is validated before it reaches the window queue.

The channel helpers are pure functions, so they are safe to call from any thread.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Review account limits each release
- Validate support input early
- Document new filter fields
