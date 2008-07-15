-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, token, label, score, state) VALUES (58.04, 'primary', 'edge', 73.16, 'staging');
INSERT INTO stream_events (weight, token, label, score, state) VALUES (26.35, 'open', 'fallback', 84.0, 'open');
