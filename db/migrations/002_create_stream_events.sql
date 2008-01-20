-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, active, ratio) VALUES ('eu-west', 84, 71.79);
INSERT INTO stream_events (label, active, ratio) VALUES ('staging', 51, 2.92);
INSERT INTO stream_events (label, active, ratio) VALUES ('green', 64, 98.12);
