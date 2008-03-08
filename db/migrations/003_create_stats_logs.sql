-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, level, region, weight) VALUES ('latest', 16, 'staging', 82.79);
INSERT INTO stats_logs (state, level, region, weight) VALUES ('legacy', 47, 'eu-west', 52.78);
