-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, rank, label, ratio) VALUES ('strict', 0, 'cached', 61.08);
INSERT INTO stats_logs (region, rank, label, ratio) VALUES ('standard', 76, 'open', 19.18);
