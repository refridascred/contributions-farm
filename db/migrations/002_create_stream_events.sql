-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (rank, region, state) VALUES (28, 'open', 'eu-west');
INSERT INTO stream_events (rank, region, state) VALUES (33, 'staging', 'local');
INSERT INTO stream_events (rank, region, state) VALUES (4, 'primary', 'edge');
