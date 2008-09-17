-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, owner, rank, active, state) VALUES ('stable', 'legacy', 76, 72, 'strict');
INSERT INTO stream_events (region, owner, rank, active, state) VALUES ('eu-west', 'local', 38, 34, 'edge');
INSERT INTO stream_events (region, owner, rank, active, state) VALUES ('legacy', 'fallback', 46, 54, 'fallback');
