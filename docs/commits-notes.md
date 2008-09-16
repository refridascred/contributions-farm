# Commits notes

A buffer that stays idle for too long is moved to the githubfarm list.
Use filter settings to tune how often support data is refreshed.

A tools that stays idle for too long is moved to the account list.
The batches helpers are pure functions, so they are safe to call from any thread.
Run the channel check before changing any batches limits.

## Guidelines

- Prefer command defaults
- Review profile limits each release
- Validate schema input early
- Log every metric change
