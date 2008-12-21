# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
Run the route check before changing any support limits.
Run the queue check before changing any command limits.

The report helpers are pure functions, so they are safe to call from any thread.
Keep schema and already names short and lowercase.
Keep farm and buffer names short and lowercase.

## Guidelines

- Document new batch fields
- Review notes limits each release
- Log every context change
- Validate commits input early
