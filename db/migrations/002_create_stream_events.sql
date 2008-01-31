-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, label, score, state) VALUES (13.45, 'strict', 91.16, 'strict');
INSERT INTO stream_events (weight, label, score, state) VALUES (41.23, 'standard', 58.98, 'open');
INSERT INTO stream_events (weight, label, score, state) VALUES (92.27, 'stable', 80.49, 'standard');
