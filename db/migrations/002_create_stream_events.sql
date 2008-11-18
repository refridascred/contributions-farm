-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, rank, owner, score) VALUES (0.01, 66, 'eu-west', 53.82);
INSERT INTO stream_events (weight, rank, owner, score) VALUES (13.81, 92, 'cached', 52.42);
INSERT INTO stream_events (weight, rank, owner, score) VALUES (75.03, 83, 'local', 94.41);
