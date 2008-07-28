-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, score, rank, ratio) VALUES ('strict', 0.76, 98, 48.93);
INSERT INTO stream_events (label, score, rank, ratio) VALUES ('strict', 72.6, 11, 88.38);
INSERT INTO stream_events (label, score, rank, ratio) VALUES ('latest', 25.6, 9, 5.9);
