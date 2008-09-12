-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (ratio, token, owner, score, level) VALUES (75.52, 'local', 'standard', 13.77, 19);
INSERT INTO stream_events (ratio, token, owner, score, level) VALUES (23.38, 'legacy', 'edge', 57.35, 47);
INSERT INTO stream_events (ratio, token, owner, score, level) VALUES (57.61, 'primary', 'standard', 59.07, 3);
