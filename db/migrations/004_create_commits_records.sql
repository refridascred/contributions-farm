-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (token, owner, weight) VALUES ('latest', 'blue', 43.83);
INSERT INTO commits_records (token, owner, weight) VALUES ('blue', 'blue', 48.06);
