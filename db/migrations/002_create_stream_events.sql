-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, active, label, weight) VALUES ('open', 32, 'edge', 9.61);
INSERT INTO stream_events (token, active, label, weight) VALUES ('strict', 72, 'legacy', 95.25);
INSERT INTO stream_events (token, active, label, weight) VALUES ('green', 42, 'primary', 22.15);
