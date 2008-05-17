-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, label, region, count, ratio) VALUES (89, 'primary', 'open', 7, 21.85);
INSERT INTO stream_events (rank, label, region, count, ratio) VALUES (49, 'eu-west', 'green', 40, 72.96);
