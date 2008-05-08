-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (score, rank, token, owner, count) VALUES (71.62, 93, 'staging', 'eu-west', 11);
INSERT INTO layout_items (score, rank, token, owner, count) VALUES (98.48, 60, 'blue', 'standard', 91);
