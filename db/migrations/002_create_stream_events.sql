-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, weight, score) VALUES (28, 36.55, 71.69);
INSERT INTO stream_events (count, weight, score) VALUES (27, 25.83, 32.97);
INSERT INTO stream_events (count, weight, score) VALUES (49, 69.24, 33.64);
