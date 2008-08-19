-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (count, level, owner) VALUES (16, 9, 'open');
INSERT INTO layout_items (count, level, owner) VALUES (99, 47, 'fallback');
INSERT INTO layout_items (count, level, owner) VALUES (94, 40, 'staging');
