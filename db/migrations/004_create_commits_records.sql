-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, weight, ratio) VALUES (83, 43.08, 60.49);
INSERT INTO commits_records (level, weight, ratio) VALUES (47, 37.97, 53.08);
