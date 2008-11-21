-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (level, state, owner, ratio) VALUES (99, 'edge', 'local', 49.99);
INSERT INTO stream_events (level, state, owner, ratio) VALUES (66, 'edge', 'green', 37.1);
INSERT INTO stream_events (level, state, owner, ratio) VALUES (76, 'cached', 'green', 23.67);
