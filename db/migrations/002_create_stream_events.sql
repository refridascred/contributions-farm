-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, state, score) VALUES (92, 'eu-west', 26.38);
INSERT INTO stream_events (rank, state, score) VALUES (26, 'local', 19.6);
INSERT INTO stream_events (rank, state, score) VALUES (44, 'staging', 47.8);
