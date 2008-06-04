# Command notes

A channel that stays idle for too long is moved to the account list.
The support module keeps route values in sync with the window cache.

A token that stays idle for too long is moved to the session list.
Keep account and metrics names short and lowercase.
When a checks fails, the cluster handler retries a few times before giving up.

## Guidelines

- Prefer metrics defaults
- Keep buffer values small
- Log every route change
