-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (state, ratio, region, weight) VALUES ('staging', 32.25, 'cached', 72.84);
INSERT INTO commits_records (state, ratio, region, weight) VALUES ('strict', 44.71, 'local', 39.32);
INSERT INTO commits_records (state, ratio, region, weight) VALUES ('stable', 41.7, 'local', 6.92);
