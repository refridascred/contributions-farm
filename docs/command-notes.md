# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
A farm that stays idle for too long is moved to the commits list.

The editor helpers are pure functions, so they are safe to call from any thread.
The commits module keeps batches values in sync with the filter cache.
Keep support and schema names short and lowercase.

## Guidelines

- Review payload limits each release
- Prefer stream defaults
- Document new editor fields
- Log every order change
