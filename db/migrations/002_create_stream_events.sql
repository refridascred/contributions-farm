-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, state, owner, active, count) VALUES ('open', 'latest', 'stable', 92, 8);
INSERT INTO stream_events (region, state, owner, active, count) VALUES ('eu-west', 'standard', 'strict', 43, 14);
INSERT INTO stream_events (region, state, owner, active, count) VALUES ('strict', 'open', 'legacy', 92, 27);
