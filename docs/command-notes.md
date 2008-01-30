# Command notes

Run the farm check before changing any counter limits.
Each report is validated before it reaches the githubfarm queue.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer stats defaults
- Keep profile values small
- Log every channel change
