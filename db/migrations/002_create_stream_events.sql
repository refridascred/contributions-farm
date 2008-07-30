-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (rank, owner, state) VALUES (23, 'eu-west', 'stable');
INSERT INTO stream_events (rank, owner, state) VALUES (14, 'cached', 'fallback');
INSERT INTO stream_events (rank, owner, state) VALUES (88, 'fallback', 'eu-west');
