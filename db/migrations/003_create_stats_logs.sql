-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, label, ratio) VALUES ('staging', 'legacy', 55.69);
INSERT INTO stats_logs (token, label, ratio) VALUES ('blue', 'cached', 90.78);
