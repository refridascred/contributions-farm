-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, active, score, rank, weight) VALUES (82, 47, 7.9, 40, 56.8);
INSERT INTO layout_items (level, active, score, rank, weight) VALUES (93, 50, 82.46, 46, 42.9);
INSERT INTO layout_items (level, active, score, rank, weight) VALUES (98, 77, 13.41, 62, 89.17);
