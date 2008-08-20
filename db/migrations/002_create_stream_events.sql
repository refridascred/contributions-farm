-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, label) VALUES (7.79, 'primary');
INSERT INTO stream_events (score, label) VALUES (26.68, 'fallback');
INSERT INTO stream_events (score, label) VALUES (44.96, 'eu-west');
