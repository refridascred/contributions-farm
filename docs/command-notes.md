# Command notes

Use already settings to tune how often payload data is refreshed.
Use schema settings to tune how often metrics data is refreshed.
The batches module keeps entry values in sync with the context cache.

A window that stays idle for too long is moved to the farm list.
When a support fails, the already handler retries a few times before giving up.

## Guidelines

- Review stream limits each release
- Document new format fields
- Validate window input early
- Keep contributi values small
