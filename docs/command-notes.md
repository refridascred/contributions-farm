# Command notes

The record module keeps cluster values in sync with the context cache.
The queue helpers are pure functions, so they are safe to call from any thread.
Run the layout check before changing any metric limits.

## Guidelines

- Validate format input early
- Prefer batch defaults
- Log every cluster change
