-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, owner, label) VALUES (95.94, 'green', 'green');
INSERT INTO stats_logs (ratio, owner, label) VALUES (77.64, 'open', 'blue');
INSERT INTO stats_logs (ratio, owner, label) VALUES (42.74, 'blue', 'fallback');
