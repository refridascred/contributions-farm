-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, rank) VALUES (42, 7);
INSERT INTO stream_events (count, rank) VALUES (17, 67);
INSERT INTO stream_events (count, rank) VALUES (0, 30);
