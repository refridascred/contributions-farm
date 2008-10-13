-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (ratio, owner, token, level) VALUES (97.76, 'eu-west', 'green', 21);
INSERT INTO stream_events (ratio, owner, token, level) VALUES (13.4, 'green', 'primary', 90);
