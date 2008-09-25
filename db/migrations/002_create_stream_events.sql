-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, weight, count) VALUES (17, 3.93, 42);
INSERT INTO stream_events (rank, weight, count) VALUES (67, 5.49, 20);
INSERT INTO stream_events (rank, weight, count) VALUES (65, 94.96, 13);
