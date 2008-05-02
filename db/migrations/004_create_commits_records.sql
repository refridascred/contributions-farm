-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, level, weight, owner) VALUES (29.81, 91, 45.02, 'green');
INSERT INTO commits_records (ratio, level, weight, owner) VALUES (86.71, 87, 8.67, 'strict');
