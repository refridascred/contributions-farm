# Command notes

A batch that stays idle for too long is moved to the cluster list.
The filter module keeps githubfarm values in sync with the contributi cache.

Each record is validated before it reaches the token queue.
The metric report groups every batch by githubfarm.

## Guidelines

- Review metrics limits each release
- Prefer batch defaults
- Keep support values small
