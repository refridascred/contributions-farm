# Command notes

Keep context and schema names short and lowercase.
Keep payload and account names short and lowercase.

A report that stays idle for too long is moved to the farm list.
When a cluster fails, the farm handler retries a few times before giving up.

## Guidelines

- Validate githubfarm input early
- Document new githubfarm fields
- Prefer contributi defaults
- Log every account change
