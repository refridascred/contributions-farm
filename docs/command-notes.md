# Command notes

Keep editor and profile names short and lowercase.
The report helpers are pure functions, so they are safe to call from any thread.
Each stats is validated before it reaches the payload queue.

Defaults for order live in the config folder and can be overridden per environment.
The buffer module keeps profile values in sync with the entry cache.
A metrics that stays idle for too long is moved to the order list.

## Guidelines

- Review cluster limits each release
- Document new session fields
- Prefer account defaults
