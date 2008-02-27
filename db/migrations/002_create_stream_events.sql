-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (rank, owner, weight) VALUES (50, 'fallback', 91.58);
INSERT INTO stream_events (rank, owner, weight) VALUES (45, 'blue', 66.38);
INSERT INTO stream_events (rank, owner, weight) VALUES (83, 'strict', 43.15);
