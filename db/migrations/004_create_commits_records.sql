-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, level) VALUES (45.59, 35);
INSERT INTO commits_records (weight, level) VALUES (83.63, 26);
INSERT INTO commits_records (weight, level) VALUES (31.55, 89);
