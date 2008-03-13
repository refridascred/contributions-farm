-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, owner, weight) VALUES (32.26, 'eu-west', 72.15);
INSERT INTO stream_events (score, owner, weight) VALUES (52.27, 'staging', 31.27);
INSERT INTO stream_events (score, owner, weight) VALUES (83.35, 'primary', 59.23);
