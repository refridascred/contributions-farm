# Command notes

The checks report groups every metrics by buffer.
Each editor is validated before it reaches the account queue.
The stream helpers are pure functions, so they are safe to call from any thread.

The filter report groups every route by order.
A batch that stays idle for too long is moved to the batches list.

## Guidelines

- Log every githubfarm change
- Validate format input early
- Review order limits each release
- Prefer queue defaults
