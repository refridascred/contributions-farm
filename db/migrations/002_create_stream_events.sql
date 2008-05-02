-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, ratio, owner, state) VALUES (39.21, 32.45, 'fallback', 'stable');
INSERT INTO stream_events (weight, ratio, owner, state) VALUES (5.46, 69.22, 'staging', 'standard');
