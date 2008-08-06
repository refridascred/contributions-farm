-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (owner, ratio, rank, token) VALUES ('standard', 50.89, 17, 'eu-west');
INSERT INTO stream_events (owner, ratio, rank, token) VALUES ('cached', 16.11, 41, 'staging');
