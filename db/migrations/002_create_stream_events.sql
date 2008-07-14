-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, token, owner, score) VALUES (58.26, 'blue', 'standard', 61.33);
INSERT INTO stream_events (ratio, token, owner, score) VALUES (50.87, 'fallback', 'strict', 20.66);
