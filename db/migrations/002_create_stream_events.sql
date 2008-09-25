-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (active, count, region, label) VALUES (42, 63, 'green', 'fallback');
INSERT INTO stream_events (active, count, region, label) VALUES (72, 86, 'fallback', 'open');
INSERT INTO stream_events (active, count, region, label) VALUES (69, 27, 'green', 'primary');
