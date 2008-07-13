-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, active, count, score, token) VALUES ('eu-west', 66, 59, 63.6, 'standard');
INSERT INTO commits_records (label, active, count, score, token) VALUES ('cached', 93, 46, 81.69, 'local');
INSERT INTO commits_records (label, active, count, score, token) VALUES ('legacy', 53, 48, 90.69, 'cached');
