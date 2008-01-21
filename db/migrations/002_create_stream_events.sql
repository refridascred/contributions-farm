-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, rank, weight, owner) VALUES ('eu-west', 27, 59.01, 'local');
INSERT INTO stream_events (label, rank, weight, owner) VALUES ('open', 5, 79.52, 'blue');
