-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, token, label, ratio) VALUES (96.5, 'local', 'primary', 84.37);
INSERT INTO stats_logs (score, token, label, ratio) VALUES (33.4, 'primary', 'primary', 34.58);
INSERT INTO stats_logs (score, token, label, ratio) VALUES (92.34, 'eu-west', 'eu-west', 3.06);
