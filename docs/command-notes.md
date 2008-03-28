# Command notes

Run the notes check before changing any githubfarm limits.
Each already is validated before it reaches the batch queue.

A profile that stays idle for too long is moved to the queue list.
A route that stays idle for too long is moved to the cluster list.
When a githubfarm fails, the report handler retries a few times before giving up.

## Guidelines

- Prefer counter defaults
- Log every batch change
- Document new channel fields
- Review batch limits each release
