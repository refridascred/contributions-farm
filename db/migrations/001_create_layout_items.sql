-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, level, score) VALUES (93, 40, 89.1);
INSERT INTO layout_items (active, level, score) VALUES (89, 40, 28.0);
INSERT INTO layout_items (active, level, score) VALUES (52, 37, 38.96);
