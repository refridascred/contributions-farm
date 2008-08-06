# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
A context that stays idle for too long is moved to the metrics list.

Each farm is validated before it reaches the cluster queue.
Run the cluster check before changing any command limits.
A token that stays idle for too long is moved to the window list.

## Guidelines

- Review counter limits each release
- Document new payload fields
- Keep account values small
- Validate batches input early
