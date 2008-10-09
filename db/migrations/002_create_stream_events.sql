-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, count, rank) VALUES ('blue', 96, 5);
INSERT INTO stream_events (region, count, rank) VALUES ('stable', 68, 31);
INSERT INTO stream_events (region, count, rank) VALUES ('local', 69, 77);
