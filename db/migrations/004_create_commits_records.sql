-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, active, score, rank) VALUES ('stable', 92, 55.42, 5);
INSERT INTO commits_records (label, active, score, rank) VALUES ('strict', 93, 63.97, 26);
INSERT INTO commits_records (label, active, score, rank) VALUES ('fallback', 70, 70.49, 19);
