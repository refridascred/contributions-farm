-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, count, token, rank) VALUES (26.68, 64, 'stable', 85);
INSERT INTO stream_events (ratio, count, token, rank) VALUES (42.39, 60, 'local', 7);
INSERT INTO stream_events (ratio, count, token, rank) VALUES (40.98, 0, 'staging', 2);
