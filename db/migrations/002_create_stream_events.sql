-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (score, owner, rank, ratio, state) VALUES (81.26, 'open', 18, 59.33, 'staging');
INSERT INTO stream_events (score, owner, rank, ratio, state) VALUES (89.06, 'edge', 71, 79.26, 'blue');
