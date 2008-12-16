-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (score, active, state) VALUES (30.67, 9, 'standard');
INSERT INTO commits_records (score, active, state) VALUES (60.77, 41, 'primary');
INSERT INTO commits_records (score, active, state) VALUES (94.72, 52, 'eu-west');
