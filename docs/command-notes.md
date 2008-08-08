# Command notes

Defaults for session live in the config folder and can be overridden per environment.
The session module keeps window values in sync with the command cache.
Run the cluster check before changing any token limits.

Each token is validated before it reaches the batch queue.
Keep buffer and metrics names short and lowercase.

## Guidelines

- Keep schema values small
- Review metrics limits each release
- Document new channel fields
