-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, weight, rank) VALUES ('open', 25.81, 68);
INSERT INTO stream_events (owner, weight, rank) VALUES ('stable', 18.72, 3);
INSERT INTO stream_events (owner, weight, rank) VALUES ('stable', 39.06, 2);
