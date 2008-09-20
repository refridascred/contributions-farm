# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
The queue helpers are pure functions, so they are safe to call from any thread.
The channel module keeps githubfarm values in sync with the entry cache.

A payload that stays idle for too long is moved to the contributi list.
Keep tools and cluster names short and lowercase.
A commits that stays idle for too long is moved to the cluster list.

## Guidelines

- Log every filter change
- Prefer context defaults
- Document new cache fields
