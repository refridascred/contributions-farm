-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (ratio, score, state, label) VALUES (95.76, 51.61, 'strict', 'fallback');
INSERT INTO stream_events (ratio, score, state, label) VALUES (96.68, 55.56, 'green', 'green');
