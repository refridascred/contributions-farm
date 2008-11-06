-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, region, label) VALUES (25, 'edge', 'local');
INSERT INTO stream_events (count, region, label) VALUES (82, 'green', 'open');
INSERT INTO stream_events (count, region, label) VALUES (64, 'staging', 'local');
