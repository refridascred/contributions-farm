# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
The counter module keeps support values in sync with the record cache.

## Guidelines

- Validate token input early
- Document new editor fields
- Log every order change
