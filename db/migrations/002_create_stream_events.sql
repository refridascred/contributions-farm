-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, label, ratio) VALUES (97.12, 'blue', 22.77);
INSERT INTO stream_events (score, label, ratio) VALUES (35.6, 'primary', 19.84);
INSERT INTO stream_events (score, label, ratio) VALUES (36.61, 'fallback', 84.35);
