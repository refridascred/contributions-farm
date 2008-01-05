-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (level, owner, label) VALUES (10, 'legacy', 'local');
INSERT INTO stream_events (level, owner, label) VALUES (61, 'legacy', 'eu-west');
INSERT INTO stream_events (level, owner, label) VALUES (39, 'edge', 'green');
