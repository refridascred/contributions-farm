-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (ratio, count) VALUES (43.82, 16);
INSERT INTO stream_events (ratio, count) VALUES (97.04, 16);
INSERT INTO stream_events (ratio, count) VALUES (16.1, 92);
