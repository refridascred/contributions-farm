-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, level, token) VALUES (37.07, 60, 'primary');
INSERT INTO commits_records (weight, level, token) VALUES (69.21, 24, 'local');
