-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, ratio, weight, rank) VALUES ('open', 48.62, 83.54, 88);
INSERT INTO stream_events (token, ratio, weight, rank) VALUES ('latest', 72.71, 33.17, 31);
INSERT INTO stream_events (token, ratio, weight, rank) VALUES ('local', 18.22, 41.63, 99);
