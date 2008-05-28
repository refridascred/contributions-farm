-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, score) VALUES ('open', 70.86);
INSERT INTO commits_records (label, score) VALUES ('green', 61.48);
INSERT INTO commits_records (label, score) VALUES ('legacy', 52.29);
