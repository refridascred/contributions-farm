-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, score, level, region) VALUES (79, 37.51, 46, 'eu-west');
INSERT INTO stream_events (active, score, level, region) VALUES (42, 43.3, 40, 'strict');
INSERT INTO stream_events (active, score, level, region) VALUES (81, 8.93, 4, 'staging');
