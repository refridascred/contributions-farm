-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (score, label, weight) VALUES (52.18, 'staging', 81.28);
INSERT INTO stream_events (score, label, weight) VALUES (37.19, 'staging', 42.39);
INSERT INTO stream_events (score, label, weight) VALUES (97.78, 'open', 14.33);
