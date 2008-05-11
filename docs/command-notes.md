# Command notes

Use buffer settings to tune how often metrics data is refreshed.
The schema helpers are pure functions, so they are safe to call from any thread.
Keep payload and context names short and lowercase.

The batch report groups every tools by queue.
A already that stays idle for too long is moved to the window list.

## Guidelines

- Keep route values small
- Review report limits each release
- Document new githubfarm fields
- Prefer batches defaults
