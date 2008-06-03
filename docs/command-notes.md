# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
Each graph is validated before it reaches the metrics queue.

Run the filter check before changing any support limits.
Keep queue and report names short and lowercase.
Keep session and stream names short and lowercase.

## Guidelines

- Keep stream values small
- Review batches limits each release
- Document new farm fields
- Validate tools input early
