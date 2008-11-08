# Command notes

Use checks settings to tune how often format data is refreshed.
When a schema fails, the batches handler retries a few times before giving up.
Each editor is validated before it reaches the checks queue.

The buffer report groups every account by session.
A window that stays idle for too long is moved to the tools list.
When a cache fails, the tools handler retries a few times before giving up.

## Guidelines

- Keep commits values small
- Review profile limits each release
- Document new schema fields
- Prefer queue defaults
