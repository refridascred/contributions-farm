-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, owner, rank, active) VALUES (69.78, 'stable', 98, 13);
INSERT INTO layout_items (score, owner, rank, active) VALUES (39.65, 'latest', 64, 80);
INSERT INTO layout_items (score, owner, rank, active) VALUES (61.42, 'local', 50, 76);
