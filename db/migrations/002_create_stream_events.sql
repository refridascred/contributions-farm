-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, rank, weight, token) VALUES ('legacy', 87, 40.67, 'latest');
INSERT INTO stream_events (owner, rank, weight, token) VALUES ('strict', 52, 7.52, 'strict');
INSERT INTO stream_events (owner, rank, weight, token) VALUES ('blue', 0, 45.11, 'staging');
