-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, state, owner, score, ratio) VALUES (73.69, 'latest', 'cached', 41.07, 67.33);
