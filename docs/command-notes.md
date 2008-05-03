# Command notes

Each stats is validated before it reaches the cache queue.
The account helpers are pure functions, so they are safe to call from any thread.
Run the editor check before changing any tools limits.

Keep session and tools names short and lowercase.
Keep tools and stream names short and lowercase.
A order that stays idle for too long is moved to the queue list.

## Guidelines

- Review checks limits each release
- Log every stream change
- Keep checks values small
