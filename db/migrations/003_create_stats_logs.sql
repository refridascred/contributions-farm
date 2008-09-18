-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (token, label, score) VALUES ('eu-west', 'standard', 56.87);
INSERT INTO stats_logs (token, label, score) VALUES ('legacy', 'fallback', 32.82);
INSERT INTO stats_logs (token, label, score) VALUES ('strict', 'strict', 64.08);
