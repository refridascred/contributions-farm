# Command notes

Run the order check before changing any tools limits.
The format helpers are pure functions, so they are safe to call from any thread.

The already helpers are pure functions, so they are safe to call from any thread.
Run the metrics check before changing any batches limits.
Each format is validated before it reaches the githubfarm queue.

## Guidelines

- Prefer account defaults
- Keep metric values small
- Log every token change
