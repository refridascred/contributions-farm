-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (level, label, count, rank) VALUES (28, 'blue', 42, 17);
INSERT INTO stream_events (level, label, count, rank) VALUES (95, 'eu-west', 46, 99);
INSERT INTO stream_events (level, label, count, rank) VALUES (76, 'cached', 73, 23);
