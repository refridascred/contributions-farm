# Command notes

Each stats is validated before it reaches the stream queue.
Each window is validated before it reaches the record queue.
Each notes is validated before it reaches the tools queue.

When a token fails, the commits handler retries a few times before giving up.
The report report groups every filter by metric.

## Guidelines

- Document new metrics fields
- Validate notes input early
- Prefer batches defaults
