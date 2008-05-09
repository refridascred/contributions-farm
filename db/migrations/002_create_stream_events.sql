-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, rank, state) VALUES ('legacy', 92, 'fallback');
INSERT INTO stream_events (owner, rank, state) VALUES ('cached', 80, 'stable');
INSERT INTO stream_events (owner, rank, state) VALUES ('strict', 48, 'stable');
