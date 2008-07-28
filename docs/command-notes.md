# Command notes

Each order is validated before it reaches the profile queue.
Keep stats and session names short and lowercase.

Run the route check before changing any batches limits.
A batches that stays idle for too long is moved to the filter list.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new already fields
- Prefer channel defaults
- Keep batch values small
- Review metrics limits each release
