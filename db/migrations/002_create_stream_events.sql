-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, count, weight, rank) VALUES ('blue', 34, 63.68, 33);
INSERT INTO stream_events (label, count, weight, rank) VALUES ('stable', 58, 1.49, 90);
INSERT INTO stream_events (label, count, weight, rank) VALUES ('strict', 79, 21.2, 6);
