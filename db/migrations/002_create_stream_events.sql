-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, weight, score, rank) VALUES (29, 81.89, 0.92, 66);
INSERT INTO stream_events (active, weight, score, rank) VALUES (2, 85.23, 37.81, 22);
INSERT INTO stream_events (active, weight, score, rank) VALUES (49, 26.6, 44.53, 68);
