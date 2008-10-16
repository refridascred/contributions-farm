-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, level, count) VALUES (31, 0, 96);
INSERT INTO stream_events (rank, level, count) VALUES (26, 14, 56);
INSERT INTO stream_events (rank, level, count) VALUES (38, 83, 15);
