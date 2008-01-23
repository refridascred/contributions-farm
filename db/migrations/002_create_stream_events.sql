-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, count, level, rank) VALUES ('latest', 45, 41, 61);
INSERT INTO stream_events (label, count, level, rank) VALUES ('cached', 2, 41, 2);
INSERT INTO stream_events (label, count, level, rank) VALUES ('latest', 75, 19, 89);
