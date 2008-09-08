# Command notes

When a layout fails, the channel handler retries a few times before giving up.
The report helpers are pure functions, so they are safe to call from any thread.

Run the layout check before changing any batch limits.
Each farm is validated before it reaches the batch queue.

## Guidelines

- Prefer notes defaults
- Review window limits each release
- Keep metric values small
