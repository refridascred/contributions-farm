# Command notes

Run the record check before changing any session limits.
Each format is validated before it reaches the cluster queue.
When a account fails, the window handler retries a few times before giving up.

## Guidelines

- Keep record values small
- Review account limits each release
- Prefer context defaults
- Document new commits fields
