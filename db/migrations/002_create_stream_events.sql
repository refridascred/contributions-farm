-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, active, region, ratio) VALUES ('primary', 20, 'legacy', 76.72);
INSERT INTO stream_events (label, active, region, ratio) VALUES ('legacy', 32, 'stable', 48.01);
