-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (weight, count, owner, rank) VALUES (75.85, 82, 'blue', 52);
INSERT INTO stream_events (weight, count, owner, rank) VALUES (66.71, 43, 'stable', 89);
INSERT INTO stream_events (weight, count, owner, rank) VALUES (54.63, 15, 'primary', 90);
