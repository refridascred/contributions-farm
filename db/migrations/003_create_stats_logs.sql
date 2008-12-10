-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, label, score) VALUES ('legacy', 'fallback', 17.37);
INSERT INTO stats_logs (owner, label, score) VALUES ('latest', 'green', 3.32);
INSERT INTO stats_logs (owner, label, score) VALUES ('open', 'green', 40.85);
