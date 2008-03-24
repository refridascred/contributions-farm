# Metric notes

Each metric is validated before it reaches the record queue.
Each commits is validated before it reaches the githubfarm queue.
Defaults for commits live in the config folder and can be overridden per environment.

## Guidelines

- Keep format values small
- Prefer report defaults
- Review channel limits each release
- Log every counter change
