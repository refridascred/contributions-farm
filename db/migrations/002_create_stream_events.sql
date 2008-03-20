-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, label, ratio) VALUES ('standard', 'primary', 31.69);
INSERT INTO stream_events (region, label, ratio) VALUES ('latest', 'blue', 27.28);
INSERT INTO stream_events (region, label, ratio) VALUES ('fallback', 'strict', 47.07);
