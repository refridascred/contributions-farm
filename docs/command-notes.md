# Command notes

When a support fails, the githubfarm handler retries a few times before giving up.
Keep metrics and editor names short and lowercase.
Use token settings to tune how often schema data is refreshed.

Defaults for counter live in the config folder and can be overridden per environment.
The checks report groups every batches by counter.
The cache report groups every channel by farm.

## Guidelines

- Validate tools input early
- Document new window fields
- Keep queue values small
