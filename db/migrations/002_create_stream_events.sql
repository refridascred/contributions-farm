-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, token) VALUES (44.92, 'staging');
INSERT INTO stream_events (weight, token) VALUES (96.51, 'fallback');
INSERT INTO stream_events (weight, token) VALUES (57.64, 'local');
