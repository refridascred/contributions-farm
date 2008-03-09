-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (score, state, label, count, weight) VALUES (63.03, 'eu-west', 'legacy', 12, 54.85);
INSERT INTO stream_events (score, state, label, count, weight) VALUES (21.16, 'green', 'fallback', 25, 73.61);
