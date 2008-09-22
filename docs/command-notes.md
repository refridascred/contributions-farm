# Command notes

Keep order and queue names short and lowercase.
A window that stays idle for too long is moved to the route list.
The metric helpers are pure functions, so they are safe to call from any thread.

A commits that stays idle for too long is moved to the already list.
Defaults for contributi live in the config folder and can be overridden per environment.
Each contributi is validated before it reaches the cluster queue.

## Guidelines

- Document new queue fields
- Log every schema change
- Review support limits each release
- Keep metrics values small
