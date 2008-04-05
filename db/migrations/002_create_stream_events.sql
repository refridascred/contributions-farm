-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, level, owner) VALUES (50.26, 13, 'edge');
INSERT INTO stream_events (score, level, owner) VALUES (47.11, 25, 'stable');
INSERT INTO stream_events (score, level, owner) VALUES (44.66, 89, 'eu-west');
