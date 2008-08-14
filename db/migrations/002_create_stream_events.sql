-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, weight, owner, rank, label) VALUES (82.51, 54.37, 'cached', 21, 'open');
INSERT INTO stream_events (ratio, weight, owner, rank, label) VALUES (32.33, 39.28, 'edge', 48, 'staging');
INSERT INTO stream_events (ratio, weight, owner, rank, label) VALUES (96.42, 81.15, 'primary', 43, 'local');
