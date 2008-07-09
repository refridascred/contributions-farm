-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, score, count, owner) VALUES ('latest', 3.91, 19, 'green');
INSERT INTO stats_logs (label, score, count, owner) VALUES ('blue', 50.04, 76, 'standard');
INSERT INTO stats_logs (label, score, count, owner) VALUES ('standard', 77.08, 64, 'open');
