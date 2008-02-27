-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, owner, state, active, rank) VALUES ('stable', 'legacy', 'stable', 41, 72);
INSERT INTO stream_events (region, owner, state, active, rank) VALUES ('fallback', 'open', 'open', 34, 29);
INSERT INTO stream_events (region, owner, state, active, rank) VALUES ('stable', 'blue', 'eu-west', 96, 44);
