-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (state, ratio, weight, owner) VALUES ('primary', 44.05, 12.33, 'primary');
INSERT INTO stats_logs (state, ratio, weight, owner) VALUES ('eu-west', 11.17, 57.71, 'blue');
INSERT INTO stats_logs (state, ratio, weight, owner) VALUES ('fallback', 62.72, 35.72, 'staging');
