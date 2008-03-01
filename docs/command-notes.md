# Command notes

Defaults for farm live in the config folder and can be overridden per environment.
A token that stays idle for too long is moved to the channel list.

When a farm fails, the cluster handler retries a few times before giving up.
Each metric is validated before it reaches the profile queue.

## Guidelines

- Review batch limits each release
- Keep metrics values small
- Document new buffer fields
