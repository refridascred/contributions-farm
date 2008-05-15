-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (weight, score, active) VALUES (31.32, 27.07, 45);
INSERT INTO stream_events (weight, score, active) VALUES (14.6, 37.29, 48);
INSERT INTO stream_events (weight, score, active) VALUES (82.39, 86.55, 76);
