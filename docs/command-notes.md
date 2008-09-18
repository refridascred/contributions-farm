# Command notes

The session module keeps report values in sync with the farm cache.
Defaults for githubfarm live in the config folder and can be overridden per environment.

Keep batch and profile names short and lowercase.
Each counter is validated before it reaches the cluster queue.

## Guidelines

- Validate cluster input early
- Document new cluster fields
- Review already limits each release
- Log every cache change
