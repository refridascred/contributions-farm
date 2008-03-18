-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, region, owner, weight) VALUES (0, 'cached', 'stable', 7.99);
INSERT INTO commits_records (rank, region, owner, weight) VALUES (53, 'eu-west', 'stable', 58.14);
INSERT INTO commits_records (rank, region, owner, weight) VALUES (40, 'eu-west', 'primary', 64.2);
