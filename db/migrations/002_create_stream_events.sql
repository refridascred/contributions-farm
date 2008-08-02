-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, token, active, ratio, count) VALUES (73.75, 'blue', 82, 79.66, 19);
INSERT INTO stream_events (weight, token, active, ratio, count) VALUES (64.32, 'latest', 14, 78.05, 66);
