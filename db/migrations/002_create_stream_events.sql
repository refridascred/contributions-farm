-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, owner, state, count) VALUES ('stable', 'standard', 'open', 78);
INSERT INTO stream_events (region, owner, state, count) VALUES ('stable', 'blue', 'standard', 64);
INSERT INTO stream_events (region, owner, state, count) VALUES ('latest', 'local', 'open', 55);
