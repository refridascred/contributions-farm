-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (rank, weight, level) VALUES (64, 44.87, 0);
INSERT INTO stream_events (rank, weight, level) VALUES (3, 29.58, 20);
INSERT INTO stream_events (rank, weight, level) VALUES (44, 2.51, 61);
