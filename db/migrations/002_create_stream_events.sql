-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, score, token) VALUES (27.32, 32.07, 'local');
INSERT INTO stream_events (weight, score, token) VALUES (65.36, 3.81, 'standard');
INSERT INTO stream_events (weight, score, token) VALUES (2.25, 40.07, 'legacy');
