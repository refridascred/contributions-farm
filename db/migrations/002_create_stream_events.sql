-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, owner) VALUES (48, 'standard');
INSERT INTO stream_events (rank, owner) VALUES (62, 'staging');
INSERT INTO stream_events (rank, owner) VALUES (65, 'standard');
