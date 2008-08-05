# Command notes

Defaults for order live in the config folder and can be overridden per environment.
The queue helpers are pure functions, so they are safe to call from any thread.

The graph module keeps window values in sync with the graph cache.
The farm helpers are pure functions, so they are safe to call from any thread.
Run the entry check before changing any counter limits.

## Guidelines

- Validate record input early
- Prefer order defaults
- Review batches limits each release
- Document new tools fields
