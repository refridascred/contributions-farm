-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (state, owner, rank) VALUES ('latest', 'staging', 92);
INSERT INTO stream_events (state, owner, rank) VALUES ('edge', 'cached', 70);
INSERT INTO stream_events (state, owner, rank) VALUES ('standard', 'green', 0);
