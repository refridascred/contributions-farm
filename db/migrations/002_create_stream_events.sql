-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, state, owner) VALUES ('legacy', 'strict', 'primary');
INSERT INTO stream_events (region, state, owner) VALUES ('primary', 'latest', 'stable');
INSERT INTO stream_events (region, state, owner) VALUES ('local', 'staging', 'edge');
