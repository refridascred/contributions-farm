-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, label, state) VALUES (70.57, 'stable', 'green');
INSERT INTO commits_records (score, label, state) VALUES (26.75, 'staging', 'cached');
INSERT INTO commits_records (score, label, state) VALUES (52.06, 'staging', 'local');
