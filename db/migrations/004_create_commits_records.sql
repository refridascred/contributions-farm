-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (state, level, weight, ratio, label) VALUES ('green', 29, 24.62, 1.52, 'latest');
INSERT INTO commits_records (state, level, weight, ratio, label) VALUES ('edge', 44, 0.32, 21.56, 'primary');
