-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (label, owner, score) VALUES ('legacy', 'primary', 86.31);
INSERT INTO commits_records (label, owner, score) VALUES ('green', 'edge', 57.54);
INSERT INTO commits_records (label, owner, score) VALUES ('latest', 'blue', 22.84);
