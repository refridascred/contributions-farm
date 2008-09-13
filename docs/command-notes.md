# Command notes

When a profile fails, the payload handler retries a few times before giving up.
Run the filter check before changing any profile limits.

A command that stays idle for too long is moved to the command list.
Run the farm check before changing any metric limits.

## Guidelines

- Review farm limits each release
- Log every support change
- Document new githubfarm fields
- Prefer graph defaults
