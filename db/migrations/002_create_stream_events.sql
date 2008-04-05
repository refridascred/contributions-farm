-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, owner, state, token, score) VALUES (21.65, 'legacy', 'local', 'legacy', 17.69);
INSERT INTO stream_events (weight, owner, state, token, score) VALUES (17.87, 'edge', 'legacy', 'green', 22.38);
