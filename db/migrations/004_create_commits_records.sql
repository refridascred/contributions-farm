-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, count, token, score, owner) VALUES ('legacy', 55, 'blue', 6.05, 'stable');
INSERT INTO commits_records (label, count, token, score, owner) VALUES ('primary', 79, 'primary', 20.35, 'edge');
INSERT INTO commits_records (label, count, token, score, owner) VALUES ('cached', 82, 'legacy', 70.39, 'staging');
