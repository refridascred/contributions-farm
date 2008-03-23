-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, rank, state) VALUES ('staging', 34, 'fallback');
INSERT INTO stream_events (owner, rank, state) VALUES ('strict', 37, 'standard');
INSERT INTO stream_events (owner, rank, state) VALUES ('legacy', 21, 'strict');
