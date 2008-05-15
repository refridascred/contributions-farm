-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, level, rank, state) VALUES ('stable', 22, 13, 'fallback');
INSERT INTO stream_events (owner, level, rank, state) VALUES ('open', 35, 16, 'fallback');
