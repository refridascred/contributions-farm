-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, level, weight, rank) VALUES ('green', 56, 26.48, 91);
INSERT INTO stats_logs (label, level, weight, rank) VALUES ('edge', 62, 59.88, 86);
INSERT INTO stats_logs (label, level, weight, rank) VALUES ('cached', 49, 95.43, 4);
