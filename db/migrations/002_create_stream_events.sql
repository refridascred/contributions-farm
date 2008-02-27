-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, active, state, ratio) VALUES (94, 34, 'staging', 58.99);
INSERT INTO stream_events (count, active, state, ratio) VALUES (33, 55, 'blue', 86.16);
INSERT INTO stream_events (count, active, state, ratio) VALUES (5, 75, 'open', 81.65);
