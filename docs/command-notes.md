# Command notes

Each stats is validated before it reaches the order queue.
A context that stays idle for too long is moved to the checks list.
The schema module keeps support values in sync with the checks cache.

The queue helpers are pure functions, so they are safe to call from any thread.
Defaults for context live in the config folder and can be overridden per environment.
Keep already and entry names short and lowercase.

## Guidelines

- Keep profile values small
- Document new payload fields
- Prefer metrics defaults
- Review order limits each release
