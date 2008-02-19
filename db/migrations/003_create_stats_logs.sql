-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (label, ratio, level, state) VALUES ('eu-west', 30.21, 48, 'blue');
INSERT INTO stats_logs (label, ratio, level, state) VALUES ('stable', 77.72, 66, 'blue');
