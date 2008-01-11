# Command notes

The cache module keeps support values in sync with the farm cache.
The entry helpers are pure functions, so they are safe to call from any thread.

Run the commits check before changing any checks limits.
Keep payload and checks names short and lowercase.

## Guidelines

- Keep tools values small
- Log every channel change
- Review githubfarm limits each release
- Prefer metric defaults
