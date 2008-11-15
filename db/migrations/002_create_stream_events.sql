-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, rank, score) VALUES ('local', 82, 98.88);
INSERT INTO stream_events (label, rank, score) VALUES ('green', 48, 22.32);
INSERT INTO stream_events (label, rank, score) VALUES ('staging', 97, 15.66);
