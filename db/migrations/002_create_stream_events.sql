-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (ratio, owner, rank, weight) VALUES (95.72, 'blue', 90, 40.19);
INSERT INTO stream_events (ratio, owner, rank, weight) VALUES (7.63, 'staging', 59, 84.09);
