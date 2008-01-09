-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, token, level, score, weight) VALUES (48, 'staging', 74, 34.88, 7.3);
INSERT INTO stream_events (active, token, level, score, weight) VALUES (59, 'staging', 17, 45.26, 3.74);
INSERT INTO stream_events (active, token, level, score, weight) VALUES (68, 'open', 5, 29.67, 53.2);
