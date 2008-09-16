# Editor notes

The window helpers are pure functions, so they are safe to call from any thread.
Use channel settings to tune how often buffer data is refreshed.

Each contributi is validated before it reaches the tools queue.
Run the route check before changing any schema limits.

## Guidelines

- Keep metric values small
- Review farm limits each release
- Validate batches input early
- Document new order fields
