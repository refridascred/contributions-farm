-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (count, level, weight) VALUES (94, 77, 20.81);
INSERT INTO layout_items (count, level, weight) VALUES (95, 45, 2.09);
INSERT INTO layout_items (count, level, weight) VALUES (3, 98, 72.19);
