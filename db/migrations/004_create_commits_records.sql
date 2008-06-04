-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, rank, weight) VALUES ('fallback', 27, 28.69);
INSERT INTO commits_records (owner, rank, weight) VALUES ('primary', 46, 43.8);
INSERT INTO commits_records (owner, rank, weight) VALUES ('green', 94, 70.47);
