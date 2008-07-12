-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, rank, owner, token, state) VALUES (28.65, 73, 'open', 'edge', 'cached');
INSERT INTO stream_events (ratio, rank, owner, token, state) VALUES (93.07, 39, 'edge', 'eu-west', 'latest');
