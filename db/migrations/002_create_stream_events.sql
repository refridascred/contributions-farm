-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, rank, active, token) VALUES ('open', 25, 52, 'cached');
INSERT INTO stream_events (region, rank, active, token) VALUES ('primary', 34, 52, 'stable');
INSERT INTO stream_events (region, rank, active, token) VALUES ('local', 93, 44, 'local');
