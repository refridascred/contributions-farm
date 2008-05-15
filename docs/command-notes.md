# Command notes

Keep route and tools names short and lowercase.
Run the counter check before changing any batches limits.

A checks that stays idle for too long is moved to the cluster list.
The context helpers are pure functions, so they are safe to call from any thread.
Defaults for stats live in the config folder and can be overridden per environment.

## Guidelines

- Prefer metric defaults
- Validate batch input early
- Review profile limits each release
- Log every batch change
