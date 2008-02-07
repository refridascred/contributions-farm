-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, owner, ratio) VALUES (98.27, 'legacy', 3.79);
INSERT INTO stream_events (score, owner, ratio) VALUES (65.14, 'green', 59.21);
INSERT INTO stream_events (score, owner, ratio) VALUES (43.61, 'local', 53.72);
