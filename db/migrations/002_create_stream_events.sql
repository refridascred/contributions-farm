-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    rank INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, rank, weight, label) VALUES ('standard', 19, 26.06, 'standard');
INSERT INTO stream_events (token, rank, weight, label) VALUES ('open', 79, 95.9, 'staging');
