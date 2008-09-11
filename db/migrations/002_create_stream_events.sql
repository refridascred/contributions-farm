-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (level, active, weight, score) VALUES (9, 57, 78.95, 15.41);
INSERT INTO stream_events (level, active, weight, score) VALUES (57, 74, 37.99, 21.53);
