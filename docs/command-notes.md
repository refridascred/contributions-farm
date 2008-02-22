# Command notes

The stream module keeps schema values in sync with the schema cache.
Each payload is validated before it reaches the window queue.

## Guidelines

- Keep stream values small
- Log every order change
- Prefer command defaults
