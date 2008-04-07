-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, label, ratio) VALUES (94, 'local', 39.19);
INSERT INTO layout_items (level, label, ratio) VALUES (84, 'strict', 49.76);
INSERT INTO layout_items (level, label, ratio) VALUES (11, 'blue', 33.95);
