-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, label, rank, owner, ratio) VALUES (20, 'fallback', 92, 'eu-west', 3.65);
INSERT INTO stream_events (active, label, rank, owner, ratio) VALUES (67, 'green', 68, 'green', 58.5);
INSERT INTO stream_events (active, label, rank, owner, ratio) VALUES (22, 'standard', 77, 'eu-west', 70.53);
