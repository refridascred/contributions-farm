-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, ratio, token, rank) VALUES ('blue', 76.95, 'staging', 32);
INSERT INTO stream_events (owner, ratio, token, rank) VALUES ('cached', 4.82, 'local', 13);
INSERT INTO stream_events (owner, ratio, token, rank) VALUES ('primary', 36.49, 'legacy', 68);
