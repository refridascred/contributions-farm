# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
The stream module keeps payload values in sync with the commits cache.
The contributi report groups every queue by notes.

Each report is validated before it reaches the report queue.
A graph that stays idle for too long is moved to the metrics list.
Run the contributi check before changing any record limits.

## Guidelines

- Review contributi limits each release
- Prefer buffer defaults
- Keep batch values small
