-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, ratio, token, region) VALUES (32.67, 67.84, 'latest', 'green');
INSERT INTO stream_events (weight, ratio, token, region) VALUES (72.45, 48.64, 'open', 'eu-west');
INSERT INTO stream_events (weight, ratio, token, region) VALUES (21.06, 5.53, 'local', 'latest');
