-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, active, count, score, region) VALUES (69, 59, 75, 0.18, 'standard');
INSERT INTO stream_events (level, active, count, score, region) VALUES (6, 75, 96, 61.86, 'green');
INSERT INTO stream_events (level, active, count, score, region) VALUES (50, 55, 52, 13.48, 'eu-west');
