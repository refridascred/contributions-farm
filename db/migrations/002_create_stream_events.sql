-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, ratio, owner, weight, rank) VALUES (75, 0.48, 'blue', 40.73, 19);
INSERT INTO stream_events (count, ratio, owner, weight, rank) VALUES (64, 57.67, 'cached', 46.99, 87);
