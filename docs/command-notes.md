# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
A context that stays idle for too long is moved to the entry list.

## Guidelines

- Document new graph fields
- Log every batches change
- Keep layout values small
- Validate editor input early
