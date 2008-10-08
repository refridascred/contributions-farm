-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (score, level, owner, region, state) VALUES (30.44, 61, 'green', 'legacy', 'cached');
INSERT INTO stream_events (score, level, owner, region, state) VALUES (55.98, 86, 'strict', 'strict', 'latest');
