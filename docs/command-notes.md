# Command notes

Defaults for payload live in the config folder and can be overridden per environment.
The batch module keeps cache values in sync with the commits cache.
Keep entry and metric names short and lowercase.

Each filter is validated before it reaches the buffer queue.
A githubfarm that stays idle for too long is moved to the account list.

## Guidelines

- Prefer report defaults
- Log every window change
- Document new batches fields
- Keep stats values small
