-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, ratio, score, region) VALUES ('cached', 98.45, 62.49, 'blue');
INSERT INTO stream_events (label, ratio, score, region) VALUES ('local', 70.88, 88.23, 'primary');
INSERT INTO stream_events (label, ratio, score, region) VALUES ('strict', 21.34, 86.66, 'open');
