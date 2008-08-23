# Command notes

Run the queue check before changing any schema limits.
Each metric is validated before it reaches the account queue.
The buffer helpers are pure functions, so they are safe to call from any thread.

Run the filter check before changing any stats limits.
Each farm is validated before it reaches the already queue.
The entry module keeps editor values in sync with the buffer cache.

## Guidelines

- Keep cache values small
- Log every batch change
- Validate layout input early
- Review context limits each release
