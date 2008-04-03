-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, state, level, owner, ratio) VALUES (0, 'legacy', 16, 'legacy', 52.07);
INSERT INTO stream_events (active, state, level, owner, ratio) VALUES (19, 'latest', 30, 'blue', 73.37);
INSERT INTO stream_events (active, state, level, owner, ratio) VALUES (16, 'legacy', 94, 'edge', 88.99);
