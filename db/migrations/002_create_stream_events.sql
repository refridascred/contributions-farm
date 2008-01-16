-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, count, rank) VALUES (10, 67, 18);
INSERT INTO stream_events (level, count, rank) VALUES (30, 75, 61);
INSERT INTO stream_events (level, count, rank) VALUES (14, 60, 85);
