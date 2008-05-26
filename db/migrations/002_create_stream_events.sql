-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, count) VALUES (21, 22);
INSERT INTO stream_events (rank, count) VALUES (86, 45);
INSERT INTO stream_events (rank, count) VALUES (6, 65);
