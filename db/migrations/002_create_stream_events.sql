-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, level, weight, region) VALUES ('latest', 97, 65.27, 'local');
INSERT INTO stream_events (owner, level, weight, region) VALUES ('eu-west', 24, 91.42, 'open');
