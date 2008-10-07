# Metric notes

Defaults for contributi live in the config folder and can be overridden per environment.
A token that stays idle for too long is moved to the stream list.
Each entry is validated before it reaches the cluster queue.

The checks helpers are pure functions, so they are safe to call from any thread.
Defaults for tools live in the config folder and can be overridden per environment.

## Guidelines

- Review channel limits each release
- Document new payload fields
- Prefer session defaults
- Validate record input early
