-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, level, owner) VALUES (85.62, 27, 'primary');
INSERT INTO commits_records (weight, level, owner) VALUES (75.26, 57, 'stable');
