-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    label TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, token, label, region, ratio) VALUES ('eu-west', 'primary', 'staging', 'fallback', 56.59);
INSERT INTO stats_logs (owner, token, label, region, ratio) VALUES ('staging', 'cached', 'latest', 'staging', 49.27);
INSERT INTO stats_logs (owner, token, label, region, ratio) VALUES ('legacy', 'strict', 'standard', 'primary', 0.96);
