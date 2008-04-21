-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, owner, active, level) VALUES (53, 'eu-west', 94, 52);
INSERT INTO commits_records (rank, owner, active, level) VALUES (84, 'green', 8, 84);
INSERT INTO commits_records (rank, owner, active, level) VALUES (41, 'primary', 82, 71);
