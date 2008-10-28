-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, rank, owner) VALUES (62, 97, 'open');
INSERT INTO stream_events (active, rank, owner) VALUES (56, 1, 'cached');
INSERT INTO stream_events (active, rank, owner) VALUES (57, 85, 'cached');
