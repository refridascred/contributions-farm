# Command notes

A cache that stays idle for too long is moved to the githubfarm list.
Each metric is validated before it reaches the account queue.
Keep cluster and batches names short and lowercase.

Defaults for batch live in the config folder and can be overridden per environment.
The contributi module keeps githubfarm values in sync with the githubfarm cache.

## Guidelines

- Document new format fields
- Validate cache input early
- Keep counter values small
