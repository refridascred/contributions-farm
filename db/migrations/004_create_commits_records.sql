-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (region, score, owner) VALUES ('open', 3.9, 'blue');
INSERT INTO commits_records (region, score, owner) VALUES ('latest', 70.56, 'green');
INSERT INTO commits_records (region, score, owner) VALUES ('primary', 15.99, 'green');
