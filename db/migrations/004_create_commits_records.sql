-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (token, ratio, weight) VALUES ('edge', 50.85, 96.96);
INSERT INTO commits_records (token, ratio, weight) VALUES ('edge', 15.24, 97.79);
INSERT INTO commits_records (token, ratio, weight) VALUES ('primary', 74.32, 34.46);
