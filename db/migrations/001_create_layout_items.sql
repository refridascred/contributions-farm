-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, level, active, label) VALUES (62, 47, 5, 'stable');
INSERT INTO layout_items (count, level, active, label) VALUES (17, 88, 35, 'primary');
INSERT INTO layout_items (count, level, active, label) VALUES (86, 45, 15, 'strict');
