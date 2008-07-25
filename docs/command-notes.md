# Command notes

The batches module keeps format values in sync with the context cache.
A report that stays idle for too long is moved to the batches list.

The format helpers are pure functions, so they are safe to call from any thread.
The session report groups every record by metrics.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new filter fields
- Keep editor values small
- Log every entry change
