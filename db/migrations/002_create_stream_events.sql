-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, token, score, owner, region) VALUES (94, 'blue', 12.42, 'standard', 'stable');
INSERT INTO stream_events (active, token, score, owner, region) VALUES (49, 'cached', 59.91, 'cached', 'primary');
