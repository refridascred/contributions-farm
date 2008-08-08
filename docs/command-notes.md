# Command notes

The channel report groups every checks by session.
A githubfarm that stays idle for too long is moved to the batches list.
A payload that stays idle for too long is moved to the checks list.

The record module keeps order values in sync with the graph cache.
Use entry settings to tune how often contributi data is refreshed.
Use cluster settings to tune how often payload data is refreshed.

## Guidelines

- Review contributi limits each release
- Prefer command defaults
- Keep token values small
