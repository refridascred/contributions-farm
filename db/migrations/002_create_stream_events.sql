-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, owner, token) VALUES (7.11, 'local', 'eu-west');
INSERT INTO stream_events (weight, owner, token) VALUES (43.05, 'green', 'eu-west');
INSERT INTO stream_events (weight, owner, token) VALUES (64.76, 'standard', 'blue');
