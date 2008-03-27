-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (rank, state) VALUES (42, 'blue');
INSERT INTO stream_events (rank, state) VALUES (25, 'latest');
INSERT INTO stream_events (rank, state) VALUES (94, 'cached');
