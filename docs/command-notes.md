# Command notes

Keep metric and notes names short and lowercase.
The queue module keeps batches values in sync with the support cache.

Run the filter check before changing any payload limits.
The window helpers are pure functions, so they are safe to call from any thread.
The editor helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer filter defaults
- Validate batches input early
- Document new metric fields
