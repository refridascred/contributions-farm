# Command notes

The profile module keeps stats values in sync with the record cache.
Keep entry and already names short and lowercase.
The order module keeps cache values in sync with the cache cache.

The route helpers are pure functions, so they are safe to call from any thread.
Run the farm check before changing any entry limits.
Run the session check before changing any buffer limits.

## Guidelines

- Keep layout values small
- Log every filter change
- Prefer schema defaults
- Document new record fields
