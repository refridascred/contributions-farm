# Command notes

Keep channel and cluster names short and lowercase.
Keep payload and account names short and lowercase.
When a already fails, the cluster handler retries a few times before giving up.

Defaults for batches live in the config folder and can be overridden per environment.
Each cluster is validated before it reaches the commits queue.
Run the support check before changing any contributi limits.

## Guidelines

- Review farm limits each release
- Validate editor input early
- Document new route fields
- Log every context change
