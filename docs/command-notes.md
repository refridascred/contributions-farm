# Command notes

Keep farm and token names short and lowercase.
When a route fails, the filter handler retries a few times before giving up.
Each stats is validated before it reaches the profile queue.

The farm module keeps payload values in sync with the session cache.
A window that stays idle for too long is moved to the cache list.
Each counter is validated before it reaches the contributi queue.

## Guidelines

- Log every order change
- Prefer support defaults
- Document new filter fields
