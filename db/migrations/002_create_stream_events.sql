-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, state, level, weight, score) VALUES ('cached', 'latest', 57, 98.58, 63.37);
INSERT INTO stream_events (owner, state, level, weight, score) VALUES ('stable', 'edge', 89, 92.99, 45.56);
