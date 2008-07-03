# Command notes

Defaults for commits live in the config folder and can be overridden per environment.
A cache that stays idle for too long is moved to the context list.
Run the account check before changing any buffer limits.

Each metrics is validated before it reaches the batch queue.
A profile that stays idle for too long is moved to the report list.
A batch that stays idle for too long is moved to the report list.

## Guidelines

- Keep filter values small
- Document new support fields
- Review order limits each release
