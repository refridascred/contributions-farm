-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, ratio, rank, token, owner) VALUES ('blue', 9.15, 62, 'fallback', 'primary');
INSERT INTO stream_events (region, ratio, rank, token, owner) VALUES ('local', 13.87, 44, 'eu-west', 'staging');
INSERT INTO stream_events (region, ratio, rank, token, owner) VALUES ('green', 87.39, 22, 'cached', 'latest');
