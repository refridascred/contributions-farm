-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, rank, ratio, label, region) VALUES ('staging', 55, 30.24, 'green', 'standard');
INSERT INTO stream_events (token, rank, ratio, label, region) VALUES ('cached', 79, 33.39, 'green', 'green');
INSERT INTO stream_events (token, rank, ratio, label, region) VALUES ('local', 74, 58.98, 'cached', 'strict');
