# Command notes

Run the githubfarm check before changing any notes limits.
Use profile settings to tune how often already data is refreshed.

Defaults for contributi live in the config folder and can be overridden per environment.
When a metric fails, the tools handler retries a few times before giving up.

## Guidelines

- Review batches limits each release
- Prefer metric defaults
- Validate stats input early
- Document new stats fields
