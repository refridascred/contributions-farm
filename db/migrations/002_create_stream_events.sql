-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, weight, owner, rank, score) VALUES ('standard', 95.86, 'local', 34, 8.55);
INSERT INTO stream_events (token, weight, owner, rank, score) VALUES ('blue', 91.06, 'blue', 69, 90.58);
INSERT INTO stream_events (token, weight, owner, rank, score) VALUES ('staging', 56.48, 'blue', 8, 98.75);
