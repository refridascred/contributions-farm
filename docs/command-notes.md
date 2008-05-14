# Command notes

The notes report groups every githubfarm by cluster.
Each metric is validated before it reaches the support queue.

Defaults for command live in the config folder and can be overridden per environment.
A entry that stays idle for too long is moved to the batches list.

## Guidelines

- Keep batch values small
- Log every tools change
- Validate channel input early
- Document new payload fields
