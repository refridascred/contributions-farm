# Command notes

Each farm is validated before it reaches the farm queue.
The checks module keeps editor values in sync with the cluster cache.
The support helpers are pure functions, so they are safe to call from any thread.

A token that stays idle for too long is moved to the entry list.
The batches report groups every profile by already.
Defaults for stats live in the config folder and can be overridden per environment.

## Guidelines

- Validate layout input early
- Keep batch values small
- Review filter limits each release
- Log every commits change
