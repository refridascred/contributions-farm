-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (active, weight, level) VALUES (9, 17.18, 66);
INSERT INTO stats_logs (active, weight, level) VALUES (54, 1.69, 13);
INSERT INTO stats_logs (active, weight, level) VALUES (55, 62.18, 37);
