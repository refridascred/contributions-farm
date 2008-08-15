-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, ratio, weight, label) VALUES ('legacy', 95.04, 75.5, 'primary');
INSERT INTO stats_logs (owner, ratio, weight, label) VALUES ('strict', 47.56, 95.35, 'latest');
