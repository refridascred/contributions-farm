# Command notes

Run the graph check before changing any token limits.
Keep layout and batch names short and lowercase.
A editor that stays idle for too long is moved to the stats list.

Run the support check before changing any token limits.
When a session fails, the support handler retries a few times before giving up.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every metrics change
- Document new report fields
- Keep session values small
