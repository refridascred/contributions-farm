-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, token, ratio) VALUES ('standard', 'eu-west', 18.03);
INSERT INTO stats_logs (label, token, ratio) VALUES ('eu-west', 'strict', 75.47);
INSERT INTO stats_logs (label, token, ratio) VALUES ('eu-west', 'latest', 54.08);
