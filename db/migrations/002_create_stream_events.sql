-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, region, token) VALUES (55, 'staging', 'primary');
INSERT INTO stream_events (rank, region, token) VALUES (53, 'primary', 'staging');
INSERT INTO stream_events (rank, region, token) VALUES (11, 'standard', 'cached');
