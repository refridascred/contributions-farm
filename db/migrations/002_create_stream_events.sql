-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, rank, score, owner) VALUES (83, 62, 32.1, 'green');
INSERT INTO stream_events (active, rank, score, owner) VALUES (78, 54, 74.47, 'staging');
INSERT INTO stream_events (active, rank, score, owner) VALUES (64, 60, 46.44, 'edge');
