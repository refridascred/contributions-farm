-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, owner, score) VALUES ('fallback', 'blue', 66.44);
INSERT INTO stats_logs (label, owner, score) VALUES ('green', 'blue', 9.81);
INSERT INTO stats_logs (label, owner, score) VALUES ('legacy', 'green', 37.98);
