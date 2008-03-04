# Command notes

Each batch is validated before it reaches the metric queue.
Each cluster is validated before it reaches the graph queue.
A cache that stays idle for too long is moved to the layout list.

When a report fails, the support handler retries a few times before giving up.
Keep counter and batches names short and lowercase.

## Guidelines

- Prefer contributi defaults
- Keep format values small
- Validate tools input early
- Document new contributi fields
