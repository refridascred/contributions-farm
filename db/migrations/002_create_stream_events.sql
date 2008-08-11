-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (score, owner, level, state) VALUES (34.06, 'edge', 87, 'local');
INSERT INTO stream_events (score, owner, level, state) VALUES (33.57, 'local', 3, 'strict');
INSERT INTO stream_events (score, owner, level, state) VALUES (75.4, 'cached', 5, 'local');
