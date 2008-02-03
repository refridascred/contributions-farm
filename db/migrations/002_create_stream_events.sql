-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, rank, owner) VALUES (14.31, 19, 'green');
INSERT INTO stream_events (weight, rank, owner) VALUES (35.5, 67, 'standard');
INSERT INTO stream_events (weight, rank, owner) VALUES (58.32, 0, 'staging');
