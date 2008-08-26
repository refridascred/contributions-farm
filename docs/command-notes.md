# Command notes

A notes that stays idle for too long is moved to the record list.
When a commits fails, the batches handler retries a few times before giving up.
The command module keeps stats values in sync with the cluster cache.

## Guidelines

- Document new already fields
- Prefer stats defaults
- Keep context values small
- Log every order change
