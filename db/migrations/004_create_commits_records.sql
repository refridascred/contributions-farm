-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, rank, owner, weight, label) VALUES (26, 76, 'open', 44.87, 'fallback');
INSERT INTO commits_records (active, rank, owner, weight, label) VALUES (6, 50, 'eu-west', 10.43, 'open');
INSERT INTO commits_records (active, rank, owner, weight, label) VALUES (75, 55, 'strict', 5.88, 'latest');
