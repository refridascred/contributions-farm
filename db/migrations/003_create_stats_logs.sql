-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, owner, ratio) VALUES ('blue', 'cached', 52.85);
INSERT INTO stats_logs (token, owner, ratio) VALUES ('fallback', 'primary', 36.63);
INSERT INTO stats_logs (token, owner, ratio) VALUES ('open', 'local', 48.87);
