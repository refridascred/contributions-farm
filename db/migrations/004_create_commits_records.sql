-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    region TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, weight, region, rank, active) VALUES ('staging', 64.3, 'staging', 48, 11);
INSERT INTO commits_records (token, weight, region, rank, active) VALUES ('stable', 77.08, 'green', 26, 38);
INSERT INTO commits_records (token, weight, region, rank, active) VALUES ('eu-west', 15.71, 'standard', 47, 97);
