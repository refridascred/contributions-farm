-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, owner, level, region) VALUES ('stable', 'open', 99, 'open');
INSERT INTO stream_events (state, owner, level, region) VALUES ('latest', 'blue', 36, 'open');
INSERT INTO stream_events (state, owner, level, region) VALUES ('legacy', 'staging', 94, 'staging');
