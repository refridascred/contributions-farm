-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (level, label, owner, state) VALUES (97, 'strict', 'open', 'stable');
INSERT INTO stream_events (level, label, owner, state) VALUES (47, 'edge', 'blue', 'blue');
INSERT INTO stream_events (level, label, owner, state) VALUES (79, 'green', 'latest', 'legacy');
