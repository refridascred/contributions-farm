# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Run the batches check before changing any stream limits.
The payload module keeps cluster values in sync with the account cache.

## Guidelines

- Prefer cache defaults
- Keep buffer values small
- Log every filter change
- Document new buffer fields
