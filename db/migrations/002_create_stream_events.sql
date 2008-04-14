-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, count, score, label) VALUES (68, 86, 95.19, 'open');
INSERT INTO stream_events (rank, count, score, label) VALUES (12, 65, 27.17, 'cached');
INSERT INTO stream_events (rank, count, score, label) VALUES (10, 11, 8.88, 'local');
