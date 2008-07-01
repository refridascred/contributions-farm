# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
A batches that stays idle for too long is moved to the record list.
Keep payload and session names short and lowercase.

Each filter is validated before it reaches the metric queue.
A counter that stays idle for too long is moved to the filter list.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Log every metric change
- Document new window fields
- Keep filter values small
- Review queue limits each release
