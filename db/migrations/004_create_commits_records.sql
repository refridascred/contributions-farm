-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (state, region, ratio, weight, level) VALUES ('latest', 'local', 86.7, 1.97, 63);
INSERT INTO commits_records (state, region, ratio, weight, level) VALUES ('eu-west', 'latest', 27.37, 51.72, 61);
