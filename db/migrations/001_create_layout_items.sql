-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (count, active, weight, score, rank) VALUES (97, 75, 4.38, 35.32, 57);
INSERT INTO layout_items (count, active, weight, score, rank) VALUES (0, 2, 46.25, 90.9, 58);
INSERT INTO layout_items (count, active, weight, score, rank) VALUES (54, 42, 92.18, 83.47, 8);
