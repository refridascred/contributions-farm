-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, region, weight) VALUES ('primary', 'latest', 4.97);
INSERT INTO stats_logs (state, region, weight) VALUES ('standard', 'strict', 78.28);
INSERT INTO stats_logs (state, region, weight) VALUES ('green', 'green', 7.87);
