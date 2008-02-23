# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
The editor module keeps metrics values in sync with the entry cache.

## Guidelines

- Log every batches change
- Keep report values small
- Document new session fields
- Validate channel input early
