-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, rank, owner) VALUES (70.89, 90, 'legacy');
INSERT INTO stream_events (ratio, rank, owner) VALUES (80.71, 62, 'local');
INSERT INTO stream_events (ratio, rank, owner) VALUES (2.69, 70, 'staging');
