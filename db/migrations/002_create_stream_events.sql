-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, ratio, token, level) VALUES (50, 50.46, 'green', 60);
INSERT INTO stream_events (active, ratio, token, level) VALUES (72, 37.21, 'latest', 38);
