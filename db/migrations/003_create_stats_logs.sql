-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, score, ratio, label) VALUES ('staging', 87.93, 34.8, 'staging');
INSERT INTO stats_logs (owner, score, ratio, label) VALUES ('staging', 31.64, 1.72, 'latest');
INSERT INTO stats_logs (owner, score, ratio, label) VALUES ('staging', 26.77, 50.76, 'staging');
