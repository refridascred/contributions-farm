# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
Each window is validated before it reaches the commits queue.

Run the support check before changing any contributi limits.
Use counter settings to tune how often stream data is refreshed.

## Guidelines

- Validate support input early
- Keep report values small
- Review token limits each release
