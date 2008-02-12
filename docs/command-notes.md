# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
A token that stays idle for too long is moved to the editor list.

## Guidelines

- Validate already input early
- Keep batches values small
- Document new checks fields
- Prefer batch defaults
