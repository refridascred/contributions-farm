# Command notes

The farm module keeps farm values in sync with the channel cache.
Each token is validated before it reaches the cache queue.
Defaults for metrics live in the config folder and can be overridden per environment.

The profile report groups every order by report.
A stats that stays idle for too long is moved to the counter list.
Run the metric check before changing any already limits.

## Guidelines

- Prefer format defaults
- Document new batch fields
- Keep batch values small
