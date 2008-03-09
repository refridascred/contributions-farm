# Command notes

The contributi report groups every counter by metric.
Keep buffer and session names short and lowercase.

The window helpers are pure functions, so they are safe to call from any thread.
Each report is validated before it reaches the farm queue.

## Guidelines

- Validate format input early
- Prefer token defaults
- Document new order fields
- Log every token change
