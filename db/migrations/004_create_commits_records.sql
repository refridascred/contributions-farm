-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    weight REAL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, rank, weight, level) VALUES (96.35, 80, 33.38, 73);
INSERT INTO commits_records (ratio, rank, weight, level) VALUES (34.74, 12, 63.93, 86);
