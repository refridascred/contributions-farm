-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (state, weight, count, active) VALUES ('stable', 29.36, 83, 50);
INSERT INTO stream_events (state, weight, count, active) VALUES ('open', 86.92, 48, 39);
INSERT INTO stream_events (state, weight, count, active) VALUES ('green', 64.28, 91, 57);
