-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, level, weight, owner) VALUES ('local', 31, 36.27, 'latest');
