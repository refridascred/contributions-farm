-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (weight, active, level, score, ratio) VALUES (75.92, 5, 51, 43.26, 16.99);
INSERT INTO stream_events (weight, active, level, score, ratio) VALUES (27.06, 1, 55, 84.16, 69.49);
