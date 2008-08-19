-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, label, region, weight) VALUES ('legacy', 'latest', 'standard', 58.81);
INSERT INTO stats_logs (state, label, region, weight) VALUES ('blue', 'standard', 'strict', 55.76);
INSERT INTO stats_logs (state, label, region, weight) VALUES ('strict', 'stable', 'latest', 65.13);
