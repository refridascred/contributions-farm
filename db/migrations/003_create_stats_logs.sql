-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, score, ratio) VALUES ('cached', 79.45, 11.73);
INSERT INTO stats_logs (label, score, ratio) VALUES ('fallback', 57.99, 11.19);
INSERT INTO stats_logs (label, score, ratio) VALUES ('open', 20.29, 7.95);
