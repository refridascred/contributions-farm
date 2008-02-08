-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (region, score, label) VALUES ('primary', 77.79, 'strict');
INSERT INTO stream_events (region, score, label) VALUES ('legacy', 41.48, 'green');
INSERT INTO stream_events (region, score, label) VALUES ('stable', 30.06, 'fallback');
