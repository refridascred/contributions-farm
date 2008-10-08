-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, owner, weight, rank, score) VALUES ('open', 'strict', 42.56, 4, 53.3);
INSERT INTO commits_records (label, owner, weight, rank, score) VALUES ('cached', 'standard', 17.89, 45, 65.01);
INSERT INTO commits_records (label, owner, weight, rank, score) VALUES ('green', 'eu-west', 85.48, 54, 54.84);
