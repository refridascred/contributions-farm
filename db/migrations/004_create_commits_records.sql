-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, active, rank) VALUES ('cached', 8, 50);
INSERT INTO commits_records (token, active, rank) VALUES ('blue', 7, 26);
INSERT INTO commits_records (token, active, rank) VALUES ('legacy', 45, 77);
