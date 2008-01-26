-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (count, token, owner, region, score) VALUES (64, 'open', 'fallback', 'standard', 64.37);
INSERT INTO stream_events (count, token, owner, region, score) VALUES (95, 'open', 'local', 'strict', 44.66);
