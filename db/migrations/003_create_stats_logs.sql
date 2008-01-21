-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, weight, label) VALUES (14, 46.77, 'fallback');
INSERT INTO stats_logs (active, weight, label) VALUES (72, 63.27, 'blue');
