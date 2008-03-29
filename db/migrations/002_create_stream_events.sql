-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, rank, ratio) VALUES ('strict', 57, 55.45);
INSERT INTO stream_events (label, rank, ratio) VALUES ('latest', 23, 40.72);
INSERT INTO stream_events (label, rank, ratio) VALUES ('local', 85, 46.24);
