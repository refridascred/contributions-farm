-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, level, region, weight, rank) VALUES (38, 66, 'green', 69.09, 27);
INSERT INTO stream_events (active, level, region, weight, rank) VALUES (49, 39, 'edge', 32.16, 67);
INSERT INTO stream_events (active, level, region, weight, rank) VALUES (42, 14, 'eu-west', 82.77, 93);
