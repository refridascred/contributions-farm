# Command notes

Keep record and stream names short and lowercase.
Each metrics is validated before it reaches the context queue.
The tools module keeps order values in sync with the batches cache.

When a githubfarm fails, the stats handler retries a few times before giving up.
A session that stays idle for too long is moved to the githubfarm list.

## Guidelines

- Log every editor change
- Validate editor input early
- Document new session fields
- Review graph limits each release
