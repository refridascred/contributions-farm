-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, owner, score, region) VALUES ('open', 'stable', 22.93, 'fallback');
INSERT INTO stream_events (label, owner, score, region) VALUES ('latest', 'primary', 78.85, 'latest');
