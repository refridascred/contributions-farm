# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
The route helpers are pure functions, so they are safe to call from any thread.

Run the queue check before changing any profile limits.
Run the batches check before changing any stats limits.

## Guidelines

- Review already limits each release
- Document new record fields
- Validate farm input early
