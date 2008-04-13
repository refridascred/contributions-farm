# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
The command module keeps filter values in sync with the buffer cache.
Run the layout check before changing any entry limits.

## Guidelines

- Prefer githubfarm defaults
- Validate counter input early
- Log every schema change
