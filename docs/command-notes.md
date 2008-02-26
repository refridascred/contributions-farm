# Command notes

When a batches fails, the profile handler retries a few times before giving up.
A window that stays idle for too long is moved to the account list.
The checks report groups every stats by batch.

Each githubfarm is validated before it reaches the session queue.
A commits that stays idle for too long is moved to the record list.
The entry module keeps tools values in sync with the session cache.

## Guidelines

- Validate githubfarm input early
- Log every account change
- Keep payload values small
