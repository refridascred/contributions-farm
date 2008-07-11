-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (ratio, state, token, count, weight) VALUES (86.22, 'primary', 'strict', 21, 46.22);
INSERT INTO stream_events (ratio, state, token, count, weight) VALUES (85.18, 'open', 'edge', 94, 73.62);
