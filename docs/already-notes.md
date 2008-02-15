# Already notes

Each filter is validated before it reaches the record queue.
The tools helpers are pure functions, so they are safe to call from any thread.
Keep filter and filter names short and lowercase.

Defaults for farm live in the config folder and can be overridden per environment.
The account module keeps profile values in sync with the cluster cache.

## Guidelines

- Validate report input early
- Document new entry fields
- Log every context change
- Keep token values small
