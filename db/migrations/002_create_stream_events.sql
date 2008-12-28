-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, score, token, count) VALUES (11.47, 47.85, 'primary', 29);
INSERT INTO stream_events (weight, score, token, count) VALUES (27.38, 20.25, 'strict', 90);
INSERT INTO stream_events (weight, score, token, count) VALUES (90.53, 50.2, 'primary', 53);
