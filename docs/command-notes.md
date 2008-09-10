# Command notes

The batches module keeps window values in sync with the batch cache.
A window that stays idle for too long is moved to the channel list.

Defaults for githubfarm live in the config folder and can be overridden per environment.
Run the contributi check before changing any batch limits.

## Guidelines

- Document new batch fields
- Keep stream values small
- Prefer context defaults
