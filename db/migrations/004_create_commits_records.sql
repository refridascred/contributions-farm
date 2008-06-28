-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, ratio, token, rank, weight) VALUES ('blue', 46.06, 'standard', 74, 94.57);
INSERT INTO commits_records (region, ratio, token, rank, weight) VALUES ('green', 10.29, 'blue', 74, 3.63);
INSERT INTO commits_records (region, ratio, token, rank, weight) VALUES ('open', 36.1, 'primary', 71, 8.89);
