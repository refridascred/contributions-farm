# Command notes

The batches module keeps session values in sync with the record cache.
The metrics report groups every format by entry.

A notes that stays idle for too long is moved to the batch list.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate stream input early
- Log every batches change
- Keep commits values small
