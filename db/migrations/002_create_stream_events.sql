-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (state, rank, score, label) VALUES ('open', 90, 59.68, 'eu-west');
INSERT INTO stream_events (state, rank, score, label) VALUES ('edge', 20, 31.13, 'local');
INSERT INTO stream_events (state, rank, score, label) VALUES ('staging', 26, 61.09, 'standard');
