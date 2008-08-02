-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (region, count, active, rank) VALUES ('strict', 45, 76, 75);
INSERT INTO stream_events (region, count, active, rank) VALUES ('cached', 56, 76, 85);
INSERT INTO stream_events (region, count, active, rank) VALUES ('latest', 76, 91, 14);
