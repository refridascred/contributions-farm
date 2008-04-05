-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    level INTEGER,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (state, rank, level, token) VALUES ('legacy', 43, 52, 'local');
INSERT INTO stream_events (state, rank, level, token) VALUES ('local', 50, 97, 'green');
INSERT INTO stream_events (state, rank, level, token) VALUES ('eu-west', 11, 78, 'local');
