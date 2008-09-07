-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    region TEXT,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, token, region, rank, label) VALUES (88, 'stable', 'standard', 72, 'strict');
INSERT INTO stream_events (level, token, region, rank, label) VALUES (54, 'open', 'primary', 58, 'blue');
