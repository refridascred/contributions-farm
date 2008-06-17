-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, owner, rank, label, level) VALUES (12.03, 'legacy', 44, 'standard', 28);
INSERT INTO commits_records (score, owner, rank, label, level) VALUES (79.54, 'standard', 7, 'primary', 46);
INSERT INTO commits_records (score, owner, rank, label, level) VALUES (28.5, 'stable', 34, 'local', 82);
