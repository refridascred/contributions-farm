-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, ratio) VALUES (3, 35.7);
INSERT INTO stream_events (count, ratio) VALUES (52, 72.35);
INSERT INTO stream_events (count, ratio) VALUES (60, 51.04);
