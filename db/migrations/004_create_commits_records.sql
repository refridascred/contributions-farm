-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, count, score, active) VALUES ('primary', 38, 25.91, 22);
INSERT INTO commits_records (state, count, score, active) VALUES ('edge', 50, 57.63, 23);
INSERT INTO commits_records (state, count, score, active) VALUES ('latest', 28, 91.58, 97);
