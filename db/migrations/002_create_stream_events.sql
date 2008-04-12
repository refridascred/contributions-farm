-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (rank, active, label, owner, region) VALUES (8, 20, 'stable', 'green', 'cached');
INSERT INTO stream_events (rank, active, label, owner, region) VALUES (50, 45, 'green', 'green', 'standard');
INSERT INTO stream_events (rank, active, label, owner, region) VALUES (71, 84, 'green', 'local', 'cached');
