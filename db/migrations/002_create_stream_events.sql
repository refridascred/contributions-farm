-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (level, state, owner, region) VALUES (38, 'stable', 'blue', 'legacy');
INSERT INTO stream_events (level, state, owner, region) VALUES (41, 'open', 'strict', 'latest');
INSERT INTO stream_events (level, state, owner, region) VALUES (42, 'primary', 'cached', 'legacy');
