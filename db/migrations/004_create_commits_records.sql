-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (owner, rank, score, level) VALUES ('latest', 66, 77.2, 70);
INSERT INTO commits_records (owner, rank, score, level) VALUES ('open', 33, 60.61, 27);
INSERT INTO commits_records (owner, rank, score, level) VALUES ('latest', 85, 66.23, 89);
