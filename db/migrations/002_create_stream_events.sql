-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (token, active, region) VALUES ('blue', 41, 'primary');
INSERT INTO stream_events (token, active, region) VALUES ('eu-west', 21, 'primary');
INSERT INTO stream_events (token, active, region) VALUES ('primary', 7, 'green');
