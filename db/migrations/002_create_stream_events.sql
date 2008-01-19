-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, level, owner, weight, label) VALUES ('latest', 0, 'standard', 3.87, 'green');
INSERT INTO stream_events (token, level, owner, weight, label) VALUES ('legacy', 94, 'blue', 37.29, 'strict');
