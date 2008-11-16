-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, score, region, label) VALUES (74, 73.13, 'primary', 'blue');
INSERT INTO stream_events (level, score, region, label) VALUES (79, 18.51, 'stable', 'eu-west');
