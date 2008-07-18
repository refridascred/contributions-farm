-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (state, label, rank, token) VALUES ('local', 'standard', 63, 'blue');
INSERT INTO stream_events (state, label, rank, token) VALUES ('blue', 'blue', 83, 'cached');
INSERT INTO stream_events (state, label, rank, token) VALUES ('standard', 'local', 1, 'stable');
