-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, label, weight, owner) VALUES ('cached', 'fallback', 66.48, 'staging');
INSERT INTO stream_events (token, label, weight, owner) VALUES ('fallback', 'edge', 37.85, 'legacy');
