-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    label TEXT,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, level, label, rank) VALUES ('legacy', 32, 'eu-west', 70);
INSERT INTO stream_events (token, level, label, rank) VALUES ('green', 1, 'standard', 63);
INSERT INTO stream_events (token, level, label, rank) VALUES ('local', 76, 'edge', 38);
