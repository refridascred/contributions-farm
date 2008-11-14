# Command notes

When a layout fails, the account handler retries a few times before giving up.
Each metric is validated before it reaches the githubfarm queue.
A token that stays idle for too long is moved to the already list.

Each filter is validated before it reaches the tools queue.
Use metrics settings to tune how often order data is refreshed.

## Guidelines

- Keep tools values small
- Log every profile change
- Review format limits each release
- Prefer profile defaults
