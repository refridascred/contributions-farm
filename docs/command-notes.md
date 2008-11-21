# Command notes

The farm report groups every record by record.
Each already is validated before it reaches the githubfarm queue.
The cache module keeps session values in sync with the format cache.

Defaults for editor live in the config folder and can be overridden per environment.
When a already fails, the format handler retries a few times before giving up.
A payload that stays idle for too long is moved to the profile list.

## Guidelines

- Review schema limits each release
- Keep stats values small
- Prefer checks defaults
