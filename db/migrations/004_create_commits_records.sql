-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, score, rank) VALUES ('green', 18.3, 84);
INSERT INTO commits_records (label, score, rank) VALUES ('local', 30.71, 76);
INSERT INTO commits_records (label, score, rank) VALUES ('blue', 53.07, 47);
