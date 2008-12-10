-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, level, owner, ratio) VALUES (98.76, 10, 'staging', 86.62);
INSERT INTO stream_events (score, level, owner, ratio) VALUES (77.55, 94, 'strict', 65.7);
INSERT INTO stream_events (score, level, owner, ratio) VALUES (78.64, 82, 'latest', 23.83);
