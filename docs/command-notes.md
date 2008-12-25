# Command notes

A entry that stays idle for too long is moved to the context list.
The entry module keeps report values in sync with the farm cache.
When a metric fails, the entry handler retries a few times before giving up.

A payload that stays idle for too long is moved to the metrics list.
Keep queue and account names short and lowercase.
The command report groups every support by session.

## Guidelines

- Prefer cache defaults
- Review context limits each release
- Keep contributi values small
- Validate payload input early
