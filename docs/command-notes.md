# Command notes

Run the counter check before changing any account limits.
Run the batches check before changing any channel limits.
The batches module keeps account values in sync with the route cache.

Keep window and cache names short and lowercase.
The record module keeps githubfarm values in sync with the counter cache.
The session module keeps profile values in sync with the profile cache.

## Guidelines

- Prefer account defaults
- Review checks limits each release
- Keep githubfarm values small
- Log every stats change
