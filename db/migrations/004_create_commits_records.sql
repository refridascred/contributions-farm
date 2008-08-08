-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, token, rank) VALUES (8.07, 'staging', 26);
INSERT INTO commits_records (weight, token, rank) VALUES (23.53, 'local', 34);
INSERT INTO commits_records (weight, token, rank) VALUES (16.83, 'edge', 84);
