-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, active, score) VALUES (3.82, 5, 40.7);
INSERT INTO stream_events (ratio, active, score) VALUES (11.23, 40, 66.81);
INSERT INTO stream_events (ratio, active, score) VALUES (67.15, 51, 69.14);
