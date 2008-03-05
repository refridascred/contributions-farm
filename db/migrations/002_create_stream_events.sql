-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, count, weight) VALUES (20.54, 88, 96.79);
INSERT INTO stream_events (score, count, weight) VALUES (1.22, 8, 92.84);
INSERT INTO stream_events (score, count, weight) VALUES (29.97, 7, 79.65);
