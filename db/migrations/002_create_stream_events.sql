-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, level, token, score, ratio) VALUES ('primary', 98, 'strict', 82.75, 90.84);
INSERT INTO stream_events (label, level, token, score, ratio) VALUES ('stable', 59, 'primary', 97.37, 66.32);
