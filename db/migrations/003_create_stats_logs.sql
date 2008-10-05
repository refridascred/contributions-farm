-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, rank, ratio, active, token) VALUES ('blue', 62, 82.33, 43, 'primary');
INSERT INTO stats_logs (label, rank, ratio, active, token) VALUES ('eu-west', 83, 50.18, 92, 'standard');
