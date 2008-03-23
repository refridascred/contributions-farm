-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, active, rank) VALUES (34, 68, 39);
INSERT INTO stream_events (level, active, rank) VALUES (87, 7, 62);
INSERT INTO stream_events (level, active, rank) VALUES (31, 10, 20);
