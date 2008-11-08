-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, weight, owner, score, token) VALUES ('latest', 28.23, 'standard', 20.87, 'edge');
INSERT INTO stream_events (region, weight, owner, score, token) VALUES ('standard', 32.11, 'primary', 24.77, 'primary');
