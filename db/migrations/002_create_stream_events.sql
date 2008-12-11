-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, ratio, label) VALUES ('blue', 33.56, 'primary');
INSERT INTO stream_events (token, ratio, label) VALUES ('legacy', 69.71, 'legacy');
INSERT INTO stream_events (token, ratio, label) VALUES ('staging', 24.8, 'latest');
