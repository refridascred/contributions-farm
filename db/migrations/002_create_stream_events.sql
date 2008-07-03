-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (level, score) VALUES (9, 40.7);
INSERT INTO stream_events (level, score) VALUES (60, 23.07);
INSERT INTO stream_events (level, score) VALUES (31, 5.87);
