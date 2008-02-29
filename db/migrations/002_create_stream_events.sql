-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, ratio, owner) VALUES ('blue', 92.46, 'strict');
INSERT INTO stream_events (token, ratio, owner) VALUES ('blue', 5.93, 'staging');
INSERT INTO stream_events (token, ratio, owner) VALUES ('blue', 53.82, 'staging');
