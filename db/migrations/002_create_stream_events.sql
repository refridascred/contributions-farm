-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, label, weight, rank, region) VALUES (34.74, 'standard', 78.95, 87, 'staging');
INSERT INTO stream_events (score, label, weight, rank, region) VALUES (53.1, 'local', 95.0, 72, 'blue');
INSERT INTO stream_events (score, label, weight, rank, region) VALUES (32.61, 'cached', 48.56, 3, 'strict');
