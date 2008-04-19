-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, ratio, label, owner) VALUES ('primary', 54.06, 'blue', 'standard');
INSERT INTO stream_events (token, ratio, label, owner) VALUES ('fallback', 57.74, 'primary', 'blue');
INSERT INTO stream_events (token, ratio, label, owner) VALUES ('cached', 78.06, 'eu-west', 'local');
