-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (level, owner, rank, label) VALUES (66, 'open', 91, 'legacy');
INSERT INTO stream_events (level, owner, rank, label) VALUES (46, 'edge', 79, 'latest');
INSERT INTO stream_events (level, owner, rank, label) VALUES (89, 'fallback', 91, 'local');
