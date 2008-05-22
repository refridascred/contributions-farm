-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (level, owner, region) VALUES (18, 'staging', 'stable');
INSERT INTO stream_events (level, owner, region) VALUES (61, 'local', 'standard');
INSERT INTO stream_events (level, owner, region) VALUES (64, 'stable', 'blue');
