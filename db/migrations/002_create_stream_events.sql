-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, region, token, rank, ratio) VALUES (69, 'green', 'staging', 82, 77.52);
INSERT INTO stream_events (active, region, token, rank, ratio) VALUES (37, 'standard', 'standard', 1, 26.16);
