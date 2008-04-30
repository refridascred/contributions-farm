-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, owner) VALUES (16.34, 'local');
INSERT INTO stream_events (weight, owner) VALUES (28.25, 'stable');
INSERT INTO stream_events (weight, owner) VALUES (85.71, 'primary');
