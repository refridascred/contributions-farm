-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, score, label) VALUES ('eu-west', 2.76, 'local');
INSERT INTO stream_events (region, score, label) VALUES ('strict', 38.24, 'stable');
INSERT INTO stream_events (region, score, label) VALUES ('staging', 48.16, 'latest');
