-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (owner, ratio, score, level) VALUES ('strict', 83.89, 51.43, 71);
INSERT INTO stream_events (owner, ratio, score, level) VALUES ('blue', 75.35, 5.56, 49);
INSERT INTO stream_events (owner, ratio, score, level) VALUES ('standard', 3.22, 58.17, 91);
