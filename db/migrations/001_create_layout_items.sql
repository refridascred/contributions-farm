-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (active, rank, score, owner, weight) VALUES (18, 5, 38.45, 'local', 36.83);
INSERT INTO layout_items (active, rank, score, owner, weight) VALUES (29, 43, 36.62, 'latest', 3.75);
