-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, active, region) VALUES (31.75, 96, 'legacy');
INSERT INTO stream_events (ratio, active, region) VALUES (87.06, 10, 'local');
