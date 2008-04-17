# Command notes

Run the editor check before changing any metric limits.
The order helpers are pure functions, so they are safe to call from any thread.
Each entry is validated before it reaches the batch queue.

The layout module keeps layout values in sync with the tools cache.
Run the route check before changing any counter limits.
When a record fails, the buffer handler retries a few times before giving up.

## Guidelines

- Log every order change
- Keep route values small
- Validate context input early
