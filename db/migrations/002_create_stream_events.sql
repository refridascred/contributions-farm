-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (level, weight, score) VALUES (75, 64.78, 43.72);
INSERT INTO stream_events (level, weight, score) VALUES (15, 48.78, 30.25);
INSERT INTO stream_events (level, weight, score) VALUES (64, 62.97, 13.94);
