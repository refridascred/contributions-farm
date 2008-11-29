-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, token, active, ratio) VALUES (8.98, 'green', 33, 90.08);
INSERT INTO stream_events (weight, token, active, ratio) VALUES (33.22, 'legacy', 87, 67.04);
