-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (count, level, rank) VALUES (90, 98, 63);
INSERT INTO stream_events (count, level, rank) VALUES (69, 0, 30);
