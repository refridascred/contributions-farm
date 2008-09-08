-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, count, level, active) VALUES (88, 81, 8, 78);
INSERT INTO stream_events (rank, count, level, active) VALUES (34, 18, 58, 66);
INSERT INTO stream_events (rank, count, level, active) VALUES (87, 18, 85, 2);
