-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, rank, state, level) VALUES ('green', 80, 'legacy', 43);
INSERT INTO stream_events (owner, rank, state, level) VALUES ('strict', 40, 'edge', 61);
INSERT INTO stream_events (owner, rank, state, level) VALUES ('eu-west', 45, 'fallback', 67);
