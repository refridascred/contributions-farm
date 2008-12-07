-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (rank, label, active, region) VALUES (54, 'green', 67, 'eu-west');
INSERT INTO stream_events (rank, label, active, region) VALUES (9, 'cached', 30, 'fallback');
