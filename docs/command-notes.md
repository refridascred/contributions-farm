# Command notes

The record module keeps githubfarm values in sync with the checks cache.
Run the support check before changing any metric limits.

Run the counter check before changing any layout limits.
A cache that stays idle for too long is moved to the farm list.

## Guidelines

- Prefer farm defaults
- Document new account fields
- Keep format values small
- Log every queue change
