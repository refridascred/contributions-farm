-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, count, owner, state) VALUES (44, 25, 'local', 'blue');
INSERT INTO stream_events (level, count, owner, state) VALUES (16, 57, 'fallback', 'primary');
INSERT INTO stream_events (level, count, owner, state) VALUES (80, 64, 'legacy', 'open');
