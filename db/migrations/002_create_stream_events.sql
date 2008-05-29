-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    rank INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (owner, rank, label, ratio) VALUES ('green', 41, 'latest', 29.03);
INSERT INTO stream_events (owner, rank, label, ratio) VALUES ('cached', 5, 'fallback', 54.77);
INSERT INTO stream_events (owner, rank, label, ratio) VALUES ('primary', 31, 'local', 96.69);
