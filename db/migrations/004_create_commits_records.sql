-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (owner, rank, weight, active) VALUES ('legacy', 51, 36.94, 58);
INSERT INTO commits_records (owner, rank, weight, active) VALUES ('stable', 41, 5.55, 99);
INSERT INTO commits_records (owner, rank, weight, active) VALUES ('open', 5, 97.98, 87);
