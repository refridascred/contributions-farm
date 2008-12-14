-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, ratio, owner, token, weight) VALUES (68, 80.65, 'blue', 'green', 83.62);
INSERT INTO commits_records (rank, ratio, owner, token, weight) VALUES (15, 80.67, 'strict', 'latest', 91.24);
INSERT INTO commits_records (rank, ratio, owner, token, weight) VALUES (52, 49.66, 'local', 'blue', 62.3);
