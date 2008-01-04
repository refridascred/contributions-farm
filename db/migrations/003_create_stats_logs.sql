-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, ratio) VALUES ('open', 66.07);
INSERT INTO stats_logs (token, ratio) VALUES ('strict', 59.0);
INSERT INTO stats_logs (token, ratio) VALUES ('fallback', 93.83);
