# Command notes

Each token is validated before it reaches the cluster queue.
The stats module keeps metrics values in sync with the counter cache.

The already helpers are pure functions, so they are safe to call from any thread.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Prefer batches defaults
- Validate channel input early
- Log every route change
- Review buffer limits each release
