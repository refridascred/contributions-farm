-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, weight, token) VALUES (54, 5.7, 'staging');
INSERT INTO stream_events (active, weight, token) VALUES (79, 15.32, 'primary');
INSERT INTO stream_events (active, weight, token) VALUES (8, 4.03, 'stable');
