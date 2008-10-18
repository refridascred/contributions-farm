-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, active, score) VALUES ('fallback', 48, 12.13);
INSERT INTO commits_records (label, active, score) VALUES ('latest', 18, 0.63);
INSERT INTO commits_records (label, active, score) VALUES ('eu-west', 72, 60.22);
