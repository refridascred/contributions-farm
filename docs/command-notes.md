# Command notes

Each contributi is validated before it reaches the commits queue.
Each stream is validated before it reaches the route queue.
Run the order check before changing any cluster limits.

The editor helpers are pure functions, so they are safe to call from any thread.
Run the profile check before changing any report limits.

## Guidelines

- Validate batch input early
- Document new record fields
- Keep batch values small
- Log every entry change
