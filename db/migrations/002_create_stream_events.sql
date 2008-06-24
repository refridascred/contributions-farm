-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, active, owner, state, score) VALUES ('local', 21, 'staging', 'stable', 25.7);
INSERT INTO stream_events (region, active, owner, state, score) VALUES ('fallback', 16, 'staging', 'open', 20.14);
INSERT INTO stream_events (region, active, owner, state, score) VALUES ('cached', 87, 'primary', 'latest', 16.59);
