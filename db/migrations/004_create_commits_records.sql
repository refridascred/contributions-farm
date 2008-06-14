-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (owner, weight) VALUES ('strict', 32.79);
INSERT INTO commits_records (owner, weight) VALUES ('primary', 69.18);
INSERT INTO commits_records (owner, weight) VALUES ('legacy', 72.68);
