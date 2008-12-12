-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, ratio, weight, rank) VALUES ('standard', 63.19, 23.69, 79);
INSERT INTO stream_events (owner, ratio, weight, rank) VALUES ('stable', 17.74, 60.91, 7);
