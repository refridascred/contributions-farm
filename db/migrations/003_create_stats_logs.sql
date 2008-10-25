-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (rank, active, label, level) VALUES (54, 69, 'primary', 37);
INSERT INTO stats_logs (rank, active, label, level) VALUES (66, 9, 'standard', 84);
INSERT INTO stats_logs (rank, active, label, level) VALUES (81, 66, 'stable', 55);
