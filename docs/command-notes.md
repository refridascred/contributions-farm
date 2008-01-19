# Command notes

Each entry is validated before it reaches the window queue.
When a farm fails, the batch handler retries a few times before giving up.
Run the githubfarm check before changing any support limits.

Each already is validated before it reaches the cluster queue.
Use entry settings to tune how often format data is refreshed.

## Guidelines

- Keep notes values small
- Log every farm change
- Review cluster limits each release
