-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, score, owner, rank) VALUES (18.82, 11.81, 'strict', 26);
INSERT INTO commits_records (weight, score, owner, rank) VALUES (13.79, 52.24, 'eu-west', 69);
INSERT INTO commits_records (weight, score, owner, rank) VALUES (27.11, 10.14, 'open', 41);
