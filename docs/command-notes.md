# Command notes

A already that stays idle for too long is moved to the githubfarm list.
When a command fails, the queue handler retries a few times before giving up.

Each batches is validated before it reaches the farm queue.
Run the cluster check before changing any format limits.

## Guidelines

- Review entry limits each release
- Document new checks fields
- Keep report values small
- Log every editor change
