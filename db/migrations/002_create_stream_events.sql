-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, label, token, region) VALUES (76, 'stable', 'latest', 'standard');
INSERT INTO stream_events (rank, label, token, region) VALUES (36, 'legacy', 'staging', 'open');
INSERT INTO stream_events (rank, label, token, region) VALUES (79, 'local', 'blue', 'staging');
