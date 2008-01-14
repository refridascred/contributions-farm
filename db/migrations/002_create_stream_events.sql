-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (token, active, level, weight, region) VALUES ('latest', 11, 60, 44.11, 'legacy');
INSERT INTO stream_events (token, active, level, weight, region) VALUES ('primary', 5, 7, 86.32, 'open');
