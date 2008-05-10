-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (label, active, score) VALUES ('cached', 52, 27.36);
INSERT INTO stats_logs (label, active, score) VALUES ('blue', 45, 60.13);
INSERT INTO stats_logs (label, active, score) VALUES ('primary', 97, 42.62);
