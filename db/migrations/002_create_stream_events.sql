-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (active, ratio, label) VALUES (67, 33.75, 'latest');
INSERT INTO stream_events (active, ratio, label) VALUES (43, 3.51, 'blue');
INSERT INTO stream_events (active, ratio, label) VALUES (45, 86.61, 'fallback');
