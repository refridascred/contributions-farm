-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, rank, token, score, label) VALUES ('latest', 1, 'local', 92.65, 'legacy');
