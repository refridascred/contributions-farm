-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (weight, rank, level, count, owner) VALUES (38.75, 51, 73, 60, 'open');
INSERT INTO stream_events (weight, rank, level, count, owner) VALUES (23.05, 1, 41, 42, 'eu-west');
INSERT INTO stream_events (weight, rank, level, count, owner) VALUES (18.09, 90, 47, 15, 'primary');
