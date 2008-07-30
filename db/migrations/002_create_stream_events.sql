-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, weight, active, score, rank) VALUES (51.13, 17.76, 72, 27.38, 78);
INSERT INTO stream_events (ratio, weight, active, score, rank) VALUES (67.57, 22.78, 73, 67.46, 63);
