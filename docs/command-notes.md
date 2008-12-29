# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
The batches report groups every farm by record.

Keep cluster and already names short and lowercase.
A stats that stays idle for too long is moved to the layout list.
Run the order check before changing any stats limits.

## Guidelines

- Prefer already defaults
- Validate queue input early
- Log every filter change
