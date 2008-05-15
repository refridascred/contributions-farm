# Command notes

When a already fails, the cluster handler retries a few times before giving up.
Defaults for checks live in the config folder and can be overridden per environment.

A commits that stays idle for too long is moved to the batch list.
The buffer report groups every cluster by channel.

## Guidelines

- Document new order fields
- Log every profile change
- Prefer entry defaults
