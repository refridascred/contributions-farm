-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (label, ratio, weight, rank, owner) VALUES ('stable', 40.34, 34.79, 81, 'stable');
INSERT INTO stream_events (label, ratio, weight, rank, owner) VALUES ('latest', 65.18, 41.49, 51, 'primary');
INSERT INTO stream_events (label, ratio, weight, rank, owner) VALUES ('eu-west', 31.43, 31.04, 13, 'stable');
