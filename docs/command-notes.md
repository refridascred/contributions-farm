# Command notes

When a counter fails, the batch handler retries a few times before giving up.
Each entry is validated before it reaches the cluster queue.
A entry that stays idle for too long is moved to the farm list.

Defaults for checks live in the config folder and can be overridden per environment.
A session that stays idle for too long is moved to the profile list.
The schema report groups every stats by githubfarm.

## Guidelines

- Prefer report defaults
- Review channel limits each release
- Log every counter change
- Keep graph values small
