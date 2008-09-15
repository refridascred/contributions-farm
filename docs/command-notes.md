# Command notes

Each githubfarm is validated before it reaches the cluster queue.
When a account fails, the tools handler retries a few times before giving up.
Each account is validated before it reaches the farm queue.

Keep farm and tools names short and lowercase.
A batches that stays idle for too long is moved to the session list.

## Guidelines

- Log every farm change
- Review stream limits each release
- Document new stream fields
- Validate tools input early
