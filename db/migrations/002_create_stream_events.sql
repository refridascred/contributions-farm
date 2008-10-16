-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (owner, score, weight) VALUES ('strict', 64.76, 18.15);
INSERT INTO stream_events (owner, score, weight) VALUES ('stable', 20.19, 91.49);
INSERT INTO stream_events (owner, score, weight) VALUES ('eu-west', 31.0, 46.89);
