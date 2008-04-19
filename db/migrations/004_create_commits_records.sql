-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (state, active, score, rank) VALUES ('cached', 12, 15.51, 92);
INSERT INTO commits_records (state, active, score, rank) VALUES ('open', 50, 85.04, 68);
INSERT INTO commits_records (state, active, score, rank) VALUES ('latest', 12, 56.68, 86);
