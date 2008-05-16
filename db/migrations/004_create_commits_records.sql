-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, active, token, rank, weight) VALUES ('open', 19, 'staging', 93, 76.73);
INSERT INTO commits_records (owner, active, token, rank, weight) VALUES ('green', 85, 'edge', 15, 19.1);
INSERT INTO commits_records (owner, active, token, rank, weight) VALUES ('stable', 64, 'strict', 95, 38.99);
