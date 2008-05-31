-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, token, owner, ratio, rank) VALUES ('stable', 'latest', 'local', 8.07, 97);
INSERT INTO stream_events (label, token, owner, ratio, rank) VALUES ('strict', 'eu-west', 'edge', 92.35, 2);
INSERT INTO stream_events (label, token, owner, ratio, rank) VALUES ('cached', 'green', 'edge', 11.62, 51);
