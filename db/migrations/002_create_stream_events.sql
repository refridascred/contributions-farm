-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, level, rank) VALUES (22, 12, 39);
INSERT INTO stream_events (count, level, rank) VALUES (37, 66, 59);
INSERT INTO stream_events (count, level, rank) VALUES (98, 13, 91);
