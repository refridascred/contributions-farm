# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
The commits module keeps context values in sync with the batch cache.
Keep profile and metrics names short and lowercase.

## Guidelines

- Keep cluster values small
- Review payload limits each release
- Prefer farm defaults
