-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, label, level) VALUES (76, 'blue', 14);
INSERT INTO layout_items (count, label, level) VALUES (80, 'stable', 6);
INSERT INTO layout_items (count, label, level) VALUES (83, 'green', 89);
