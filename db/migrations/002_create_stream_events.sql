-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (score, owner, rank, ratio) VALUES (87.29, 'blue', 62, 59.56);
INSERT INTO stream_events (score, owner, rank, ratio) VALUES (83.35, 'primary', 97, 8.05);
