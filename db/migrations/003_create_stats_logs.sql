-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, label, score, ratio) VALUES ('fallback', 'local', 26.09, 38.14);
INSERT INTO stats_logs (owner, label, score, ratio) VALUES ('open', 'standard', 25.24, 87.1);
INSERT INTO stats_logs (owner, label, score, ratio) VALUES ('strict', 'latest', 65.62, 17.2);
