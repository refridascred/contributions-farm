-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (ratio, count) VALUES (54.22, 44);
INSERT INTO stream_events (ratio, count) VALUES (6.21, 22);
INSERT INTO stream_events (ratio, count) VALUES (12.54, 82);
