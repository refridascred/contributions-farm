-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (score, owner, state, ratio, level) VALUES (41.5, 'local', 'open', 1.88, 52);
INSERT INTO stream_events (score, owner, state, ratio, level) VALUES (44.22, 'edge', 'primary', 46.65, 23);
INSERT INTO stream_events (score, owner, state, ratio, level) VALUES (8.24, 'standard', 'local', 94.45, 27);
