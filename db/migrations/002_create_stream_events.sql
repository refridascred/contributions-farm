-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, rank, label, weight, region) VALUES (46, 77, 'stable', 14.94, 'local');
INSERT INTO stream_events (active, rank, label, weight, region) VALUES (53, 42, 'latest', 28.1, 'eu-west');
INSERT INTO stream_events (active, rank, label, weight, region) VALUES (4, 45, 'latest', 89.55, 'cached');
