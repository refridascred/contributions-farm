-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, ratio, weight, level) VALUES (46, 0.1, 17.49, 45);
INSERT INTO commits_records (rank, ratio, weight, level) VALUES (86, 93.38, 15.02, 61);
