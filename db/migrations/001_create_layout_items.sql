-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (count, score, active, level) VALUES (97, 47.41, 22, 21);
INSERT INTO layout_items (count, score, active, level) VALUES (23, 73.79, 45, 14);
INSERT INTO layout_items (count, score, active, level) VALUES (8, 90.18, 22, 36);
