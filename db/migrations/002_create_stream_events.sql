-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, rank, weight, label, ratio) VALUES ('standard', 33, 10.37, 'local', 90.94);
INSERT INTO stream_events (token, rank, weight, label, ratio) VALUES ('latest', 36, 61.75, 'standard', 33.92);
INSERT INTO stream_events (token, rank, weight, label, ratio) VALUES ('eu-west', 73, 77.99, 'latest', 45.73);
