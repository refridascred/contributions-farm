-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, weight, label, state) VALUES ('open', 75.33, 'legacy', 'open');
INSERT INTO stream_events (token, weight, label, state) VALUES ('open', 82.4, 'staging', 'cached');
INSERT INTO stream_events (token, weight, label, state) VALUES ('fallback', 98.79, 'staging', 'blue');
