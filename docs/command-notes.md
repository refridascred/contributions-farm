# Command notes

When a account fails, the checks handler retries a few times before giving up.
A token that stays idle for too long is moved to the order list.

Each stats is validated before it reaches the record queue.
Each report is validated before it reaches the record queue.

## Guidelines

- Log every githubfarm change
- Validate contributi input early
- Review counter limits each release
