-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, weight, rank) VALUES ('local', 77.83, 79);
INSERT INTO commits_records (owner, weight, rank) VALUES ('standard', 1.52, 90);
