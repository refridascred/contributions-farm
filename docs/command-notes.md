# Command notes

The stats module keeps route values in sync with the notes cache.
Each entry is validated before it reaches the metric queue.

## Guidelines

- Keep already values small
- Prefer session defaults
- Document new metrics fields
- Review cluster limits each release
