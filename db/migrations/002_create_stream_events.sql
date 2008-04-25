-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, label, score, region) VALUES (67, 'strict', 22.95, 'stable');
INSERT INTO stream_events (rank, label, score, region) VALUES (20, 'eu-west', 18.5, 'fallback');
