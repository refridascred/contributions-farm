# Command notes

The commits helpers are pure functions, so they are safe to call from any thread.
The batches report groups every context by editor.

## Guidelines

- Keep githubfarm values small
- Document new githubfarm fields
- Log every session change
- Validate buffer input early
