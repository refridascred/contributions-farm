# Editor notes

Each session is validated before it reaches the contributi queue.
A githubfarm that stays idle for too long is moved to the order list.
The record report groups every githubfarm by order.

The contributi report groups every farm by batches.
The schema module keeps report values in sync with the metric cache.

## Guidelines

- Keep cache values small
- Prefer tools defaults
- Review githubfarm limits each release
