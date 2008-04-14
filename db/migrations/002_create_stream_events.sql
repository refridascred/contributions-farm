-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, score, level, token) VALUES ('staging', 55.61, 64, 'stable');
INSERT INTO stream_events (region, score, level, token) VALUES ('stable', 71.22, 78, 'blue');
INSERT INTO stream_events (region, score, level, token) VALUES ('local', 46.8, 40, 'green');
