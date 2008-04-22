-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, score, owner, active) VALUES ('legacy', 19.08, 'local', 48);
INSERT INTO commits_records (label, score, owner, active) VALUES ('stable', 92.82, 'blue', 14);
INSERT INTO commits_records (label, score, owner, active) VALUES ('standard', 35.77, 'cached', 53);
