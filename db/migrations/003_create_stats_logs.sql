-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, label, owner, active) VALUES (82.98, 'primary', 'standard', 43);
INSERT INTO stats_logs (score, label, owner, active) VALUES (32.68, 'standard', 'strict', 49);
INSERT INTO stats_logs (score, label, owner, active) VALUES (21.57, 'legacy', 'primary', 38);
