-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, active, region) VALUES (90.31, 92, 'staging');
INSERT INTO stream_events (score, active, region) VALUES (25.15, 5, 'legacy');
INSERT INTO stream_events (score, active, region) VALUES (97.57, 29, 'green');
