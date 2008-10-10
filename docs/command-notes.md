# Command notes

Keep cluster and batches names short and lowercase.
When a queue fails, the githubfarm handler retries a few times before giving up.

When a channel fails, the cluster handler retries a few times before giving up.
Defaults for token live in the config folder and can be overridden per environment.

## Guidelines

- Review context limits each release
- Validate already input early
- Log every filter change
- Prefer batch defaults
