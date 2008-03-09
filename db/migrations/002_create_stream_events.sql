-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, owner) VALUES (70, 'eu-west');
INSERT INTO stream_events (rank, owner) VALUES (72, 'green');
INSERT INTO stream_events (rank, owner) VALUES (59, 'blue');
