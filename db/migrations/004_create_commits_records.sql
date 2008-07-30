-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, score, rank, label) VALUES ('strict', 91.56, 8, 'eu-west');
INSERT INTO commits_records (region, score, rank, label) VALUES ('edge', 61.14, 55, 'blue');
INSERT INTO commits_records (region, score, rank, label) VALUES ('green', 55.2, 38, 'staging');
