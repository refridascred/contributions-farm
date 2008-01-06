-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, level, token, owner, state) VALUES ('staging', 86, 'green', 'local', 'blue');
INSERT INTO stream_events (region, level, token, owner, state) VALUES ('blue', 65, 'open', 'blue', 'staging');
INSERT INTO stream_events (region, level, token, owner, state) VALUES ('stable', 9, 'local', 'strict', 'blue');
