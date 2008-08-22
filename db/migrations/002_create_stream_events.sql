-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, owner, state, count, level) VALUES ('blue', 'eu-west', 'green', 7, 16);
INSERT INTO stream_events (label, owner, state, count, level) VALUES ('local', 'latest', 'strict', 24, 24);
INSERT INTO stream_events (label, owner, state, count, level) VALUES ('edge', 'green', 'legacy', 18, 19);
