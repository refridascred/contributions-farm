-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, weight, ratio, rank) VALUES ('open', 40.87, 74.0, 10);
INSERT INTO commits_records (token, weight, ratio, rank) VALUES ('latest', 34.82, 5.58, 40);
