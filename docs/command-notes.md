# Command notes

Use payload settings to tune how often tools data is refreshed.
A notes that stays idle for too long is moved to the payload list.
The stats report groups every cache by support.

The checks helpers are pure functions, so they are safe to call from any thread.
Each notes is validated before it reaches the batches queue.
A report that stays idle for too long is moved to the report list.

## Guidelines

- Review contributi limits each release
- Validate metric input early
- Keep report values small
