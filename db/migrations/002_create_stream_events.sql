-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, weight, ratio, label) VALUES ('primary', 27.51, 16.95, 'cached');
INSERT INTO stream_events (token, weight, ratio, label) VALUES ('staging', 80.78, 6.77, 'local');
INSERT INTO stream_events (token, weight, ratio, label) VALUES ('standard', 4.65, 59.2, 'staging');
