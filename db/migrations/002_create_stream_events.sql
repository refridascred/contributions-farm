-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, state, owner, region, rank) VALUES (68, 'latest', 'latest', 'local', 51);
INSERT INTO stream_events (count, state, owner, region, rank) VALUES (94, 'local', 'fallback', 'blue', 43);
INSERT INTO stream_events (count, state, owner, region, rank) VALUES (93, 'strict', 'open', 'strict', 50);
