-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, label, owner, active) VALUES (90.62, 'fallback', 'fallback', 90);
INSERT INTO stream_events (ratio, label, owner, active) VALUES (31.89, 'edge', 'stable', 76);
INSERT INTO stream_events (ratio, label, owner, active) VALUES (92.85, 'edge', 'eu-west', 9);
