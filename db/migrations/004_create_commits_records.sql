-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    region TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, token, region, label, rank) VALUES (35.63, 'latest', 'staging', 'stable', 7);
INSERT INTO commits_records (weight, token, region, label, rank) VALUES (36.04, 'strict', 'fallback', 'staging', 57);
