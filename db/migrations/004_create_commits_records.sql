-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, score, rank, active) VALUES ('eu-west', 23.82, 82, 74);
INSERT INTO commits_records (label, score, rank, active) VALUES ('legacy', 91.96, 10, 49);
